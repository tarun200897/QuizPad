   M S B A M L   `   `   `  ���� ?  ;QDBM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:QPAD.UserControlsQPAD.UserControls  1clr-namespace:QPAD.ConvertersQPAD.Converters  clr-namespace:QPADQPAD      QPAD.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -cclr-namespace:QPAD.UserControls     .convclr-namespace:QPAD.Converters     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      lclr-namespace:QPAD     -     � Title$  Quiz PAD��$	��630��$	��770�� � WindowStyle$
 None=� � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�$	��510��$	��770�� � 	Resources ��%    .���� $��0,3,0,0q�
������._�� ���	#FF252525.+��� -    �� SelectedIndex$ 1��$��0,30,0,0q�.@��� $��Database Manager��$��16(����	#99FFFFFF.��� .+��� $��
10,10,10,0q�.+�� .+���  �� Orientation$ 
Horizontal=�$��	0,10,50,0q�.+��� $��	Subject :��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)�$��72���� -    ��Name$ 	cbsubject��$
��Left=�$	��Top=�$	��250��$��5,2,0,2q� �� 
IsEditable . $ 0��	 �� Text	 �� *Database.Subject+���� *Database.Subjects+�� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��Level : ��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)��� -   $ cblvl��$��5,0,0,0q�$
��Left=�$��Center=�$	��250��$ 0��
 �� 
IsReadOnly
 . 	 �� *Database.Level+ �� Mode$ OneWayToSource=�.@��� $
��Left=�$	��Top=�$��Level 0����Z� ��Z� �� $
��Left=�$	��Top=�$��Level 1����Z� ��Z� �� $
��Left=�$	��Top=�$��Level 2����Z� ��Z� �� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��	Chapter :��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)��� -   $ 	cbchapter��$
��Left=�$��Center=�$	��250��$��5,0,0,0q� . $ 0��	 �� *Database.Chapter+$ OneWayToSource=����� *Database.Chapters+�� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��Type : ��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)�$��57���� -   $ cbtype��$
��Left=�$��Center=�$	��250��$��5,0,0,0q�$ 0��
 . 	 �� *Database.Type+$ OneWayToSource=�.@��� $
��Left=�$	��Top=�$��Single Answer����Z� ��Z� �� $
��Left=�$	��Top=�$��Multi Answer����Z� ��Z� �� $��Questions Only: ��$
��Left=�$	��Top=�
������$��0,10,0,0q�$��16(�$��Segoe UI SemiLight)�'   !QPAD.UserControls.QDBMRichTextBox  -     Name$ txtqns��$
��Left=� J� IsHitTestVisible . $	��Top=�$��	10,10,0,0q�
�������{�. 
���   �   CodeControlsVisibility$ 	Collapsed=�   ToolbarBorderThickness$ 1,1,1,0q�$��Segoe UI)�   ToolbarBackground �	#19FFFFFF   ToolbarBorderBrush �	#FFABADB3$��12(�   Document �� *Database.Document+����  �� Path$ ActualHeight� �� ConverterParameter$" Int32.Parse(values[0]) - 250�� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ 
TabControlL� �� 	Converter &    QPAD.Converters.JScriptConverter  � $
��0,10q�.+��� $ 
Horizontal=�$
��Left=�.+��� $��	Backup : ��$
��Left=�$	��Top=�$��0q�
������$��16(�$��Segoe UI SemiLight)�d�    MetroToggleButton#���   ���	#99FFFFFF$��0,0,0,0q�$
��Auto��$
��Auto��$��Segoe UI SemiLight)�$��16(� d� 	IsChecked �� *Database.Backup+$ OneWayToSource=��� $ 
Horizontal=�$��Right=�.+��� -    ��Name$ 
ButtonLoad��$��Load Document��$��Right=�$	��Top=�$��10,0,0,0q�$��16(�$��Segoe UI SemiLight)����� *Database.LoadCommand+�� -	   $ ButtonCreate��$��Create/Modify Database��$��Right=�$	��Top=�$��10,0,0,0q�$��16(�$��Segoe UI SemiLight)����� *Database.UpdateCommand+�� $��Generate Questions��$��16(����	#99FFFFFF.��� .+��� $��
10,10,10,0q�.+�� .+��� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��	Subject :��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)�$��72���� -
   $ 
cbsubjecta��$
��Left=�$	��Top=�$	��250��$��5,2,0,2q�$ 0�� . 
 . 	 �� *Generator.Subject+���� *Generator.Subjects+�� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��Level : ��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)��� -   $ cblvla��$��5,0,0,0q�$
��Left=�$��Center=�$	��250��$ 0��
 . 	 �� *Generator.Level+$ OneWayToSource=�.@��� $
��Left=�$	��Top=�$��Level 0����Z� ��Z� �� $
��Left=�$	��Top=�$��Level 1����Z� ��Z� �� $
��Left=�$	��Top=�$��Level 2����Z� ��Z� �� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��	Chapter :��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)��� -   $ 
cbchaptera��$
��Left=�$��Center=�$	��250��$��5,0,0,0q� . $ 0��
 . 	 �� *Generator.Chapter+$ OneWayToSource=����� *Generator.Chapters+�� $ 
Horizontal=�$��	0,10,50,0q�.+��� $��Type : ��$
��Left=�$	��Top=�
������$��16(�$��Segoe UI SemiLight)�$��57���� -   $ cbtypea��$
��Left=�$��Center=�$	��250��$��5,0,0,0q�$ 0��
 . 	 �� *Generator.Type+$ OneWayToSource=�.@��� $
��Left=�$	��Top=�$��Single Answer����Z� ��Z� �� $
��Left=�$	��Top=�$��Multi Answer����Z� ��Z� �� $��	Preview :��$
��Left=�$	��Top=�
������$��0,10,0,0q�$��Segoe UI SemiLight)�$��16(�  -   $ 
txtpreview��$
��Left=�$ 	Collapsed=�$	��Top=�$��	10,10,0,0q�
�������$��12(�
���   �$��Segoe UI)� �	#19FFFFFF �� *Generator.Document+���� $ ActualHeight�$" Int32.Parse(values[0]) - 250�� �� $ FindAncestor=�$ 
TabControlL�   � $��	10,10,0,0q�.+��� $ 
Horizontal=�$
��Left=�.+��� $��Randomize :��$
��Left=�$��Center=�
������$��0q�$��16(�$��Segoe UI SemiLight)�d� #���   $
��Left=�$	��Top=�$��0,0,0,0q����	#99FFFFFF �� *Generator.Randomize+$ OneWayToSource=��� $��No of Questions :��$
��Left=�$��Center=�
������$��10,0,0,0q�$��16(�$��Segoe UI SemiLight)��� $��10,0,0,0q�$��16(�$	��163��$
��Left=�$��Center=�$��Segoe UI Light)����� *Generator.Qns+$ OneWayToSource=��� $ 
Horizontal=�$��Right=�.+��� -   $ 	ButtonAdd��$��	Add Topic��$
��Left=�$	��Top=�$��0,0,0,0q�$��Segoe UI SemiLight)�$��16(����� *Generator.LoadCommand+�� -   $ 
ButtonSave��$��Save...��$
��Left=�$	��Top=�$��10,0,0,0q�$��Segoe UI SemiLight)�$��16(����� *Generator.SaveCommand+�� $��About��$��16(����	#99FFFFFF.��� .+��� .+��� $
��QPAD��$#��/QDBM;component/Font/#Avenger)����	#FF0080FF$	��120(� �� TextAlignment$ Center=�$��0,10,0,0q�$��Center=�$��Center=��� $��Quiz Pad��$��Segoe UI Light)����	#FF0080FF$��30(�$ Center=�$
��10,0q�$��Center=�$��Center=��� $ 
Horizontal=�$��	10,10,0,0q�.+��� $
��Left=�$
��Wrap=�$��Current Build: ��$	��Top=����	#FF0080FF$��20(��� $
��Left=�$
��Wrap=�$��Center=����	#99FFFFFF$��20(����� *Updater.CurrentVersion+ +  %QPAD.Converters.IntToVersionConverter  �� $ 
Horizontal=�$��	10,10,0,0q�.+��� $
��Left=�$
��Wrap=�$��Latest Build: ��$	��Top=����	#FF0080FF$��20(��� $
��Left=�$
��Wrap=�$��Center=����	#99FFFFFF$��20(����� *Updater.NewVersion+   ]� $��	10,10,0,0q�.+��� $
��Left=�$
��Wrap=�$��Changelog: ��$	��Top=����	#FF0080FF$��20(��� $��Center=����	#99FFFFFF$��20(�" �� VerticalScrollBarVisibility$
 Auto=�$
��10,0q� �� 
IsReadOnly .  �� TextWrapping$
 Wrap=� . ���� *Updater.Changelog+��Z� ��Z� .������ $ ActualHeight�$" Int32.Parse(values[0]) - 450�� �� $ FindAncestor=�$ 
TabControlL�   .���� $ 
Horizontal=�$��	10,10,0,0q�.+��� $
��Left=�$
��Wrap=�$��Status: ��$	��Top=����	#FF0080FF$��20(��� $
��Left=�$
��Wrap=�$��Center=����	#99FFFFFF$��20(����� *Updater.Status+�� $ 
Horizontal=�$��	10,10,0,0q�.+��� $
��Left=�$
��Wrap=�$!��Designed and Developed by: ��$	��Top=����	#FF0080FF$��20(��� $
��Left=�$
��Wrap=�$��Tarun Kancharayan��$��Center=����	#99FFFFFF$��20(��� $ 
Horizontal=�$��	10,10,0,0q�.+��� $
��Left=�$
��Wrap=�$��Conceptualized by : ��$	��Top=����	#FF0080FF$��20(��� $
��Left=�$
��Wrap=�$	��Top=�$��Segoe UI Light)����	#99FFFFFF$��20(�$��Ramanjaneyulu Singamneni���� $ 
Horizontal=�$��	10,10,0,0q�$��Center=�.+��� $��Refresh��$��Center=�$	��Top=�$��20(�$	��5,0q����� *Updater.RefreshCommand+�� $��Update��$��Center=�$	��Top=�$��20(�$	��5,0q����� *Updater.UpdateCommand+�� {�.  
������ �� -   $ ButtonClose��  NormalButton#���  $��Right=�$	��Top=�$��40��$��37��$��Segoe UI Symbol)�$��20(�.��� .+�F� $��16��$��16�������� 	@(�� V	@(�Ѡ{5	�M�@�[	@(�р�j	@(�р�j	�j���D	 �$р�j	��Jр�j	 �Y�@�[	 �YѠ{5	`�3� V	 �Y�� 	 �Y�� 	��J�`9&	 �$�� 	�j��� 	@(� �� Stretch$
 Fill=����� *
Foreground+ �� *FindAncestor+" ���� -   $ ButtonRestore��#���  $	��⬒��$��Right=�$	��Top=�$��40��$��37��$��Segoe UI Symbol)�$��20(�$��0,0,40,0q��� -   $ 	ButtonMin��#���  $	��▁��$��Right=�$	��Top=�$��32��$��32��$��Segoe UI Symbol)�$��20(�$��0,0,80,0q��� -     ��Name$  lbltitle��$
��QPAD��$
��Left=�$	��Top=�
������$��20(�$��3,5,0,0q�$#��/QDBM;component/Font/#Avenger)�