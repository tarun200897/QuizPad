   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MetroToggleButton  �� 
TargetType �� Property �� Value �� 
TargetType'    !System.Windows.VisualStateManager    VisualStateGroups%   System.Windows.VisualStateGroup   States    System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty	 g� Duration8  2System.Windows.Media.Animation.EasingColorKeyFrame
 �� KeyTime �� Value<   6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime p� Value � ColumnDefinitions � RowDefinitions J� SnapsToDevicePixels ��Name ��Name J� Opacity J� IsHitTestVisible �� Triggers P� Property P� Value �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  69   8d2http://schemas.microsoft.com/expression/blend/2008  6�   %�
  &	        �� 5      "  d�6&   .�5   
   ��  � ��
 �   �6'   �� 5   
    � ��$ Center=�67   �� 5   
    � ��$ Center=�65   �� 5   
    � ��$	 160��6"   �� 5	   
    � ��$ 33��6#   �� 5
   
    � �� 5      �� 5      " d�6"   .R�5      �  5        5      CommonStates��. 5   "     Checked��. 5   &   �� .��5   *   �� $ ColourBorder��6G   $1 +(Border.Background).(SolidColorBrush.Color)�6l   $	 0:0:0.1D�6�   .g�5   .     $
 	00:00:0.1��6B   $ 
DodgerBlue��6V   5   +   r� 5   *   $ (FrameworkElement.Margin)�6K   $ SlidingBorder��6�   .	�5   .     $ 0:0:0.1��6F   $ 60,0,0,0q�6X   5   +   5   '   5   #     5   "   	Unchecked��. 5   &   �� .��5   *   �� $ ColourBorder��6G   $1 +(Border.Background).(SolidColorBrush.Color)�6l   $	 0:0:0.1D�6�   .g�5   .     $
 	00:00:0.1��6B   $ Transparent��6V   5   +   r� 5   *   $ (FrameworkElement.Margin)�6K   $ SlidingBorder��6�   .	�5    .     $ 0:0:0.1��6F   $ 0q�6X   5!   +   5"   '   5#   #   5$       5&      �� 5'      $��* �6/   �� 5(      $��80 �6/   �� 5)      $��80 �6/    5+      �� 5,      $��33 �6,   .+�5.      � $��0��6   .+�5/      �� #��z��6(   #��z��6R   $��Center=�6x   # z 6�   $��Center=�6�   �� 50      ��. 60   51      52      � 53      $��1��6   .+�54      �� $ Offlabel��6(   $��16(�6:   $��Segoe UI Semibold)�6H   $
��Wrap=�6g   $	��OFF��6{   #��z��6�   $��Center=�6�   $��Center=�6�   �� 55      $ Onlabel��6(   $��16(�69   $��Segoe UI Semibold)�6G   $
��Wrap=�6f   $��ON��6z   #��z��6�   $��Center=�6�   $��Center=�6�   56      � 57      $��2��6   $��0��6E   ��6/   Z� .+�58      �� $��0q�6%   $��80��6:   ���	#FFA59F93._�59   "   �� $ ColourBorder��6)   $��3q�6?   
������ ���	#FF252525$��2q�6{   5:      �� 5;      $ SlidingBorder��6%   $��20��6<   $
��Left=�6G   
���   �6b   5<      �� 5=      $ DisabledBorder��6!   $��0q�69   $��3��6M   
�������$ 0Q�6t    .  6�   5>       5?      P� 5@       �@d�	IsChecked$
 trueY�67   . �5A      �� $ Onlabel��6;    � y�$ Visible=�6P   �� 5B      $ Offlabel��6;    � y�$ Hidden=�6Q   5C      P� 5D       �@d�	IsChecked$ falseY�67   . �5E      �� $ Onlabel��6;    � y�$ Hidden=�6P   �� 5F      $ Offlabel��6;    � y�$ Visible=�6Q   5G      P� 5H       � {� .  . �5I      �� $ DisabledBorder��68    �@J�Opacity$
 0.35Q�6T   5J      5L      5N      5O      5P      