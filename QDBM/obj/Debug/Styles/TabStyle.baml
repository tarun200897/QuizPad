   M S B A M L   `   `   `  ����?  ;QPAD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QPAD.ConvertersQPAD.Converters  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FocusVisual  �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  TabItem.Static.Background �� Color  TabItem.Static.Border   TabItem.MouseOver.Background  TabItem.MouseOver.Border  TabItem.Selected.Border  TabItem.Selected.Background �� 
TargetType `� 	Converter&     QPAD.Converters.TabSizeConverter �� RelativeSource �� Mode	 �� AncestorType
 �� Path �� 
TargetType �Name ��Name J� 	AllowDrop ��Name �� TextAlignment �� Triggers P� Property P� Value �� 
TargetName-  'System.Windows.Input.KeyboardNavigation   TabNavigation � ColumnDefinitions ��Name � RowDefinitions ��Name ��Name   TabIndex K� IsItemsHost K� ZIndex   DirectionalNavigation ��Name�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      &convclr-namespace:QPAD.Converters  5      %|  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    '�� |    7   7  7  '�� �    7  7  �� 5      .�5   
   ��   � �� 5      �� 5	      .R�5
      �� $��2q�6     . #��� ��6F   $��1��6�   $	 1 2R�6�   5      5      5      �� 5      $ 	#FFEBEBEB��68   �� 5      $ 	#FF898C95��64   �� 5      $ 	#FFD9F0FC��6;   �� 5      $ 	#FF3C7FB1��67   �� 5      $ 	#FF898C95��66   �� 5      $ 	#00FFFFFF��6:   �� 5      " ��6   .�5   
   ��   �@�FocusVisualStyle8   6-   �� 5   
     � ��
 �   �6'   �� 5   
     � ��8  6'   �� 5   
     � ��8  6(   �� 5   
     � ��$ 0q�6#   �� 5   
     � ��$ Segoe UI Light)�6'   �� 5   
     � ��$ Stretch=�67   �� 5   
     � ��$ Stretch=�65   �� 5   
     � �� 5      `� 5        5!         5"      .1�5$      ��  6   �� $ FindAncestor=�"	 ���� 5&      $
 ActualWidth�5'   0    5&      �� $ FindAncestor=�"	 ��5'   0   5(      5*      �� 5+   
     � �� 5,      �� 5-      " ��6"   .R�5.      � $ templateRoot��6    . $
��Auto��6L   $
��Auto��6Z   .+�5/      �� $ 
mainBorder��6!   $��0,0,0,3q�65   $��0q�6O    .  ���	#FF4D4D4D._�50      � .+�51   "   �� $ content��6,   $��0,5,15,0q�52   ,   $
 Left=�6>   ��51   =   �� *
Foreground+ �� "	 ���� 53      $��Header��6"   |�.  #��z��55   !   ��. # z 56   !   ��54      �� *HorizontalContentAlignment+ �� "	 ����57   !   �� *VerticalContentAlignment+ �� "	 ��58   #   59      5:      5;       5<      P� 5=       �@J�IsMouseOver . . �5>      �� $ 
mainBorder��6<     � �� �	#B21E90FF6T   5?      P� 5@       � {� .  . �5A      �� $ content��68     �@J�Opacity$
 0.56Q�6M   5B      P� 5C       �@��
IsSelected . . �5D      ��   �@K�ZIndex$ 1��6=   �� 5E        � ��$ 0q�67   �� 5F      $ 
mainBorder��6<     � ��
 ����6T   5G      5I      5K      5L      �� 5M      " ��6   .�5N   
   ��   � ��$ 0q�6$   �� 5O   
     � ��$ Center=�67   �� 5P   
     � ��$ Center=�65   �� 5Q   
     � ��8   6'   �� 5R   
     � ��8  6(   �� 5S   
     � ��$ 0q�6,   �� 5T   
     � ��# � ��6'   �� 5U   
     � �� 5V      �� 5W      " ��6"   .R�5X      � $ templateRoot��6   }�.  . $ Local=�6`    5Y      �� 5Z      $ ColumnDefinition0��6/   �� 5[      $ ColumnDefinition1��6/   $��0 �6J    5]      �� 5^      $ RowDefinition0��6,   $
��Auto �6D   �� 5_      $ RowDefinition1��6,   $��* �6D   .+�5a      � $��0��6   $��0q�6/   $��0��6:   ���	#00FFFFFF.+�5b      �� $��0,0,0,0q�6%   ._�5c   "   �� $ headerPanel��6+   $ 1��6@    . $ 1��6t   5d      5e      �� 5f      $ contentPanel��6!   #��z��67   #��z��6c   $��0��6�   $ 	Contained=�6�   $��1��6�   $ 2��6�   $ Local=�6	  ._�5g      �� $ PART_SelectedContentHost��6/   $��SelectedContent��6Q   #��z��6q   # z 6�   5h      5i       5j      P� 5k       �@��TabStripPlacement$ Bottom=�6?   . �5l      �� $ headerPanel��69     � ��$ 1��6R   �� 5m      $ contentPanel��69     � ��$ 0��6S   �� 5n      $ RowDefinition0��67     � ��$ * �6S   �� 5o      $ RowDefinition1��67     � ��$
 Auto �6S   �� 5p      $ headerPanel��67     � ��$ 2,0,2,2q�6P   5q      P� 5r       �@��TabStripPlacement$
 Left=�6?   . �5s      �� $ headerPanel��69     � ��$ 0��6R   �� 5t      $ contentPanel��69     � ��$ 0��6S   �� 5u      $ headerPanel��6<     � ��$ 0��6U   �� 5v      $ contentPanel��6<     � ��$ 1��6V   �� 5w      $ ColumnDefinition0��66     � ��$	 150 �6U   �� 5x      $ ColumnDefinition1��66     � ��$ * �6U   �� 5y      $ RowDefinition0��67     � ��$ * �6S   �� 5z      $ RowDefinition1��67     � ��$ 0 �6S   �� 5{      $ headerPanel��67     � ��$ 0q�6P   5|      P� 5}       �@��TabStripPlacement$ Right=�6?   . �5~      �� $ headerPanel��69     � ��$ 0��6R   �� 5      $ contentPanel��69     � ��$ 0��6S   �� 5�      $ headerPanel��6<     � ��$ 1��6U   �� 5�      $ contentPanel��6<     � ��$ 0��6V   �� 5�      $ ColumnDefinition0��66     � ��$ * �6U   �� 5�      $ ColumnDefinition1��66     � ��$
 Auto �6U   �� 5�      $ RowDefinition0��67     � ��$ * �6S   �� 5�      $ RowDefinition1��67     � ��$ 0 �6S   �� 5�      $ headerPanel��67     � ��$ 0,2,2,2q�6P   5�      P� 5�       � {� .  . �5�      �� $ templateRoot��6G   # � ��6a     � ��5�      5�      5�      5�      5�      