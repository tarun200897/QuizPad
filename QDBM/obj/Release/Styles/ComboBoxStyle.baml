   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxToggleButton  �� 
TargetType � ColumnDefinitions ��Name F�Name �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName	 �� Property
 �� Value P� Property P� Value  ComboBoxTextBox �� 
TargetType �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-    'System.Windows.Input.KeyboardNavigation    DirectionalNavigation  P� 
SourceName! �� Triggers�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %]  &	        &	     '�� D    7   7  �� "  d�.R��  �� �� $��20 �.+��� $ Border��$��2��
��������� $��0��$��0q�
�������$��0q�F� $ Arrow��$��1�����	#FF1E51FF$��Center=�$��Center=�"����        � 	=  	= � z     	 ]�  ��  �@J�IsMouseOver . ��  �@d�	IsChecked$ falseY�./��� $ Border��	 � ��

 �����P�  � {� .  . ��� $ Border��	 � ��
 �	#FF888888�� $ Border��	 � ��
 �	#FF888888�� 	 � ��
 �	#FF888888�� $ Arrow��	 � ��
 �	#FF888888�� "  ��.R��� $ PART_ContentHost��|�.  #��z���� " ��.��� 	 �@J�SnapsToDevicePixels
 . �� 	 �@�OverridesDefaultStyle
 . �� 	 � ��$

 Auto=��� 	 � ��$

 Auto=��� 	 � ��
 . �� 	 � ��$	
 120���� 	 � ��$
 20���� 	 � ��

 �   ��� 	 � ��
 �� "  ��.R�� .+�d� $��ToggleButton��8��  $��2��|�.  $ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+�� $��ContentSite�� .  #��z #��z #��z��$��3,3,23,3q�$��Center=�$
��Left=��� $ PART_EditableTextBox��8�� $
��Left=�$��Center=�$��3,3,23,3q�|�. 
������ $y�Hidden=�# z ��Z� � $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $ DropDownBorder��
�������$��0q��� $��4,6,4,6q� . .����  . $ 	Contained=� P�  �@��HasItems .  . ��� $ DropDownBorder��	 � ��$
 95��P�  � {� .  . ��� 	 � ��
 �	#FF888888P�  �@��
IsGrouping . . ��� 	 � ��
 .  P� $  Popup�� �@�AllowsTransparency . . ��� $ DropDownBorder��	 � ��$
 0,0,0,0q�P�  �@��
IsEditable . . ��� 	 � ��
 .  �� $ PART_EditableTextBox��	 � y�$
 Visible=��� $ ContentSite��	 � y�$
 Hidden=�! 