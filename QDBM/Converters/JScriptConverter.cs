using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace QPAD.Converters
{
    public class JScriptConverter : 
#if !SILVERLIGHT
 MarkupExtension, IMultiValueConverter,
#endif
IValueConverter
    {
        private delegate object Evaluator(string code, object[] values);
        private Evaluator evaluator;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
        public JScriptConverter()
        {
            string source =
                @"import System; 

                class Eval
                {
                    public function Evaluate(code : String, values : Object[]) : Object
                    {
                        return eval(code);
                    }
                }";

            
            CompilerParameters cp = new CompilerParameters();
            cp.GenerateInMemory = true;
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
               if (assembly.GetType().Name == "RuntimeAssembly" && System.IO.File.Exists(assembly.Location))
                    cp.ReferencedAssemblies.Add(assembly.Location);

            CompilerResults results = (new Microsoft.JScript.JScriptCodeProvider())
                .CompileAssemblyFromSource(cp, source);

            Assembly result = results.CompiledAssembly;

            Type eval = result.GetType("Eval");

            evaluator = (Delegate.CreateDelegate(
                typeof(Evaluator),
                Activator.CreateInstance(eval),
                "Evaluate") as Evaluator);
        }

        private bool trap = false;
        public bool TrapExceptions
        {
            get { return this.trap; }
            set { this.trap = true; }
        }

        public object Convert(object[] values, System.Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                return evaluator(parameter.ToString(), values);
            }
            catch
            {
                if (trap)
                    return null;
                else
                    throw;
            }
        }

        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            return Convert(new object[] { value }, targetType, parameter, culture);
        }


        public object[] ConvertBack(object value, System.Type[] targetTypes,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotSupportedException();
        }
    }
}
