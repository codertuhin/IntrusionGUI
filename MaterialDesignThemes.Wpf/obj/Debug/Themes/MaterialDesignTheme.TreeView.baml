   M S B A M L   `   `   `  ����I  Eost.design, Version=1.2.0.21900, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  5      Y1clr-namespace:MaterialDesignThemes.Wpf.Converters#MaterialDesignThemes.Wpf.Converters  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries=    7MaterialDesignThemes.Wpf.Converters.BrushRoundConverter   Key?   9MaterialDesignThemes.Wpf.Converters.MathMultipleConverter   	Operation  MaterialDesignTreeView �� 
TargetType �� Property �� Value  MaterialDesignBody �� 
TargetType ��Name J� SnapsToDevicePixels ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName �� Triggers ) %MaterialDesignTreeViewItemFocusVisual + 'MaterialDesignExpandCollapseToggleStyle'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   From	   To   GeneratedEasingFunction0  *System.Windows.Media.Animation.QuarticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   GeneratedDuration   States   System.Windows.VisualState   
Storyboard F�Name J� RenderTransformOrigin �� Angle �� CenterX  �� CenterY  MaterialDesignTreeViewItem! �� RelativeSource" �� AncestorType# � ColumnDefinitions$ � RowDefinitions%   Name.	  (System.Windows.Media.Animation.CubicEase&   Name	' W� To( g� Duration) R� KeyTime
  System.Windows.Visibility* 
  Visible+ R� Value, 
  	Collapsed- d�Name. �� 	ClickMode/ d� 	IsChecked0 J� IsHitTestVisible1 J� Opacity  BrushRoundConverter2 �� 	Converter3 �Name%   MaterialDesignThemes.Wpf.Ripple4   Feedback5 ��Name6 ��Name  MathMlpMultipleConverter7 `� 	Converter8 �� ElementName9 �� Path: ��Name�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .wpf&clr-namespace:MaterialDesignThemes.Wpf  5      @
converters1clr-namespace:MaterialDesignThemes.Wpf.Converters  5      1system&clr-namespace:System;assembly=mscorlib  5        5      �� 5   
      5	      BrushRoundConverter  6-     5
      MathMlpMultipleConverter  $ Multiply=�6P   5      %�  &	       &	 G    &	 �    &	 �    7  7  7  7  7  7  �� 5      " R�6+   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � �� 6(   Z� �� 5   
    � ��$ 0q�6,   �� 5   
    � ��# �  6'   �� 5   
    � ��$ 1q�6$   �� 5   
    � ��$
 Auto=�6G   �� 5   
    � ��$
 Auto=�6E   �� 5   
    �@��PanningMode$
 Both=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    � ��$ Center=�65   �� 5   
    � �� 5      �� 5      " R�6"   .R�5      �� $ Bd��6   #��z��6)   #��z��6U    . ._�5      �� $ _tv_scrollviewer_��6'   #��z��6B   ��.  |�.  #��z��6�   #��z��6�   # z 6  #��z��6T  .��5      �� 5      5       	 5!      P� 5"      
 � {� .  . �5#      ��  �@J�Opacity$	 .56Q�68   5$      P� 5%      
 �@%�IsVirtualizing . . �5&      �� $ _tv_scrollviewer_��6A    � �� . 6`   5'      5)      5+       5,   
   P� 5-      
 �@%�IsVirtualizing . . �5.      ��  � �� 5/      �� 50      .R�51      $� 52      54      55      57      �� 59      .�5:   
   ��  � �� 5;      �� 5<      .R�5=      �� 5>      5@      5A      �� 5C      " d�6<   .�5D   
   ��  � |� .  6&   �� 5E   
    � ��$ 16��6"   �� 5F   
    � ��$ 16��6#   �� 5G   
    � �� 5H      �� 5I      " d�6"   .R�5J      �� 
������ $��16��66   $��16��6B    5K        5L      CheckStates�� 5M   "     5N   &   $ 	Unchecked��67   $ Checked��6H    5O   *     5P   .   $ EaseOut=�6:   . 5R   *   �� .��5S   .   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6L   $ 
ExpandPath��6�   .\�5T   2     $ 0��6G   $ 0Q�6S     5U   2   $ 0:0:0.2��6G   $ 45Q�6Y   5V   /   5W   +   5X   '     5Y   &   $ 0D�67   $ 	Unchecked��6M   . 5Z   *   �� .��5[   .   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6L   $ 
ExpandPath��6�   .\�5\   2     $ 0��6G   $ 45Q�6S   5]   /   5^   +   5_   '     5`   &   $ 0D�67   $ Checked��6M   . 5a   *   �� .��5b   .   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6L   $ 
ExpandPath��6�   .\�5c   2     $ 0��6G   $ 0Q�6S   5d   /   5e   +   5f   '     5g   &   $ Checked��67   $ 0D�6F   $ 	Unchecked��6\    5h   *     5i   .   $ EaseOut=�6:   . 5k   *   �� .��5l   .   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6L   $ 
ExpandPath��6�   .\�5m   2     $ 0��6G   $ 45Q�6S     5n   2   $ 0:0:0.2��6G   $ 0Q�6Y   5o   /   5p   +   5q   '   . 5s   "     Checked��. 5t   &   �� .��5u   *   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6H   $ 
ExpandPath��6�   .\�5v   .     $ 0:0:0.2��6C   $ 45Q�6U   5w   +   5x   '   5y   #     5z   "   	Unchecked��. 5{   &   �� .��5|   *   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6H   $ 
ExpandPath��6�   .\�5}   .     $ 0:0:0.2��6C   $ 0Q�6U   5~   +   5   '   5�   #   5�      ._�5�      (� .��5�      �� $��24��6%   $��24��60   .+�5�   "   F� $ 
ExpandPath��5�   /   P���p�� �G�z�0@�P��  � Ѱ� Pq р�� ��[ � $�  � р�� ��Q�� �G�z�0@	 . #��z��5�   /   #��z��5�   /   $ .5,.5&�6U   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   $ 0Q�6>   $ 4Q�6H   $  4Q�6T   T� 5�   .   5�   +   5�   #   5�      5�      5�      5�      5�      5�      �� 5�      " Q�6/   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � �� 67   �� *HorizontalContentAlignment+! �� "" ���� 5�   
    � �� 65   �� *VerticalContentAlignment+! �� "" ���� 5�   
    � ��$ 8q�6$   �� 5�   
    �@�FocusVisualStyle8   6-   �� 5�   
    � �� 6'   �� *
Foreground+! �� "" R��� 5�   
    � �� 5�      �� 5�      " Q�6"   .R�5�      � # 5�      �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $��* �6/   $ 5�      �� 5�      $
��Auto �6,   �� 5�       5�        5�      $% CommonStates��6/    5�   "     5�   &   $ 0:0:0.3D�67   $ Normal��6S    5�   *   	  5�   .   $ EaseOut=�68   5�   '   . 5�   "     $& Normal��6.     5�   "   $& 	MouseOver��6.   . 5�   &   �� .��5�   *   W� $ MouseOverBorder��6:   $ Opacity�6b   $	' 0.1X�5�   >   $( 0D�6G   5�   '   5�   #     5�   "   $& Disabled��6.   5�        5�      SelectionStates�� 5�   "     5�   &   $ 0:0:0.6D�67   . 5�   "     $& Selected��6.   . 5�   &   �� .��5�   *   W� $ SelectedBorder��6:   $ Opacity�5�   :   $
' 0.18X�5�   :   $( 0D�6D   5�   '   5�   #     5�   "   $& 
Unselected��6.   5�        5�      ExpansionStates�� 5�   "     5�   &   $ 0D�67   $ Expanded��6M    5�   *   	  5�   .   $ EaseOut=�68   . 5�   *   �� .��5�   .   T� $ 	ItemsHost��6L   $ 
Visibility�6n   ..�5�   2   i� $) 0��6I   #+ Z* 6U   5�   /   W� 5�   .   $ Opacity�6>   $ 	ItemsHost��6b   $' 1X�6�   $( 0:0:0.3D�6�   5�   +   5�   '     5�   &   $ 0D�67   $ 	Collapsed��6M    5�   *   	  5�   .   $ EaseOut=�68   . 5�   *   �� .��5�   .   T� $ 	ItemsHost��6L   $ 
Visibility�6n   ..�5�   2   i� $) 0:0:0.3��6I   #+ Z, 6[   5�   /   W� 5�   .   $ Opacity�6>   $ 	ItemsHost��6b   $' 0X�6�   $( 0:0:0.3D�6�   5�   +   5�   '   . 5�   "     Expanded��. 5�   &   �� .��5�   *   W� $ Opacity�6:   $ 	ItemsHost��6^   $' 1X�6�   $( 0D�6�   T� 5�   *   $ 	ItemsHost��6H   $ 
Visibility�6j   ..�5�   .   i� $) 0��6E   #+ Z* 6Q   5�   +   5�   '   5�   #     5�   "   	Collapsed��. 5�   &   �� .��5�   *   W� $ Opacity�6:   $ 	ItemsHost��6^   $' 0X�6�   $( 0D�6�   T� 5�   *   $ 	ItemsHost��6H   $ 
Visibility�6j   ..�5�   .   i� $) 0��6E   #+ Z, 6Q   5�   +   5�   '   5�   #   5�      .+�5�      d� $- Expander��6'   $. Press=�69   8�� #��z��5�   '   $��8 0 8 0q�5�   '   $��Center=�5�   '   / 5�   K   �� *
IsExpanded+! �� *TemplatedParent+5�   '   �� 5     $ MouseOverBorder��6!   $��1��5  !   $��2��61   0 .  $1 0Q�5  !   ��5  !   �� *
Foreground+82  �� 5     $ SelectedBorder��6!   $��1��5	  !   $��2��61   0 .  $1 0Q�5  !   ��5  !   �� *
Foreground+82  � 5     $3 ContentGrid��6C   $��1��6   $��2��6/   
������ .+�5       |�.  # z 5  )   #��z��5  )   #��z��5  )   #��z��5  )   4 5  )   �� *
Foreground+82  .��5  "   �� $5 PART_Header��63   $��Header��6H   5     5     �� 5     $6 
ItemsPanel��5  %   $��1��5  %   $��1��65   $��	-16 0 0 0q�5  %   $��2��5  %   ��5     `� 5  "   87  .1�5  &   �� $8 	ItemsHost��6.   $9 ActualHeight�6F   �� 5   &   $8 	ItemsHost��6.   $9 Opacity�6F   5!  #   .+�5#     �� $: 	ItemsHost��6-   $	��Top=�5$  -   $1 0Q�5%  -   $y�	Collapsed=�5&  -   5'     5(     	 5)     P� 5*     
 �@��HasItems .  . �5+     �� $ Expander��6;    � y�$ Hidden=�6Q   5,     P� 5-     
 � {� .  . �5.     ��  �@J�Opacity$	 .56Q�68   5/     51     53      54  
   P� 55     
 �@%�IsVirtualizing . . �56     ��  � �� 57     �� 58     .R�59     $� 5:     5<     5=     5?     5A     