   M S B A M L   `   `   `  ����I  Eost.design, Version=1.2.0.21900, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  5      Y1clr-namespace:MaterialDesignThemes.Wpf.Converters#MaterialDesignThemes.Wpf.Converters  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089J    DMaterialDesignThemes.Wpf.Converters.TextFieldHintVisibilityConverter $   StringIsEmptyVisibilityConverter     IsEmptyValue    IsNotEmptyValue=   7MaterialDesignThemes.Wpf.Converters.BrushRoundConverter  BrushRoundConverter  MaterialDesignSeparator �� 
TargetType �� Property  MaterialDesignSelection �� Value �� 
TargetType  MaterialDesignMenu  MaterialDesignPaper  MaterialDesignFont  MaterialDesignBody �� Padding J� SnapsToDevicePixels  MaterialDesignContextMenu �� BasedOn	 J� 	CacheMode&   System.Windows.Media.BitmapCache
   EnableClearType   SnapsToDevicePixels 	 MaterialDesignShadowDepth1 J� Effect �� CornerRadius ��Name �� 
ResourceId �� TypeInTargetAssembly �� ClearTypeHint ��Name-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation � IsSharedSizeScope   TabNavigation 
 MaterialDesignMenuItem ��Name J� Opacity �� 	Converter%   MaterialDesignThemes.Wpf.Ripple   Feedback � ColumnDefinitions z� SharedSizeGroup �Name ��Name m� Icon (�Name  F�Name! �� HeaderStringFormat" �� ContentStringFormat# m� InputGestureText$ �� Stretch% �Name& � AllowsTransparency' �� RelativeSource( �� Path) �� Mode* �� AncestorType+ ��Name, �� ElementName- �� Triggers. P� Property/ P� Value0 �� 
TargetName1 ]� 
Conditions2 �� Property3 �� Value4 P� 
SourceName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .wpf&clr-namespace:MaterialDesignThemes.Wpf  5      @
converters1clr-namespace:MaterialDesignThemes.Wpf.Converters  5      %�  &	        &	 6     &	 I     &	 �    7  &	 i    7  &	
 �    7  7  7      5      $  	Collapsed=�6[   $ Visible=�6t     5      6%   �� 5	      " ��6,   .�5
   
   ��  � ��# �  6'   �� 5   
    � ��# �  6(   �� 5   
    � ��$ 1��6&   �� 5   
    �@J�SnapsToDevicePixels . 60   �� 5   
    � ��$ 16��6#   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $��1��6    #��z��6+   $��Stretch=�5       $��Center=�6>   5      5      5      �� 5      " n�6'   .�5   
   ��  � ��# �  6'   �� 5   
    � ��8   6'   �� 5   
    � ��# �  6'   �� 5   
    � ��$ 15(�6/   �� 5   
    � ��$ Center=�65   �� 5   
    � �� 5       �� 5!      " n�6"   .R�5"      �� #��z��6   #��z��5#      #��z��5$      # z��5%       . ._�5'      �� # z 6)   5(      5)      5+      5,      �� 5.      " ��6.   8   .�5/   
   ��  � �� 50      �� 51      " n�6"   .R�52      �� 	 54        55      
 .  . 6A   .u�57      �� #��z��6!   # � 	 58   !   $��3q�59   !   $ 2��5:   !   ._�5;      �� 
������ ._�5<   "   �� $ SubMenuScrollViewer��6/   ��6L   C� *�� $ MenuScrollViewer��" �+.��5=   &   � $ Enabled=�6+   $
��0 16q�6Q   .+�5>   *   �� $ ItemsPresenter��69   $ Cycle=�5?   A    . # z 5A   A   $ Cycle=�5B   A   5C   '   5D   #   5E      5F      5G      5H      5J      5K      �� 5M      " m�6    6J   Z� .�5N   
   ��  � ��$ 	24 0 24 0q�6$   68   �� 5O   
    �@�OverridesDefaultStyle . 62   �� 5P   
    � �� 5Q      �� 5R      " m�6"   .R�5S      � }�. .+�5T      �� $ templateRoot��6!   #��z��5U   !   #��z��5V   !   #��z��5W   !    . 5X   !   �� 5Y      $ BackgroundRoot��6!   #��z��5Z   !   #��z��5[   !    . $ 0Q�5^   !   ��5\   !   �� *
Foreground+8   5^   !     5_      
������ $��Stretch=�5`   )   $��Stretch=�6N   |�.   5b   )   �� *
Foreground+8  .��5c      � #��z��6#   
������ .+�5d   "   � $��Center=�6'   
������ #��z��5f   +    5g   &   �� 5h   *   $
��Auto �6;   $ 	IconGroup��6H   �� 5i   *   $��* �6;   $ HeaderGroup��6E   �� 5j   *   $��* �6;   .+�5l   &   � $ IconWrapper��6+   $y�Visible=�6@   $��40��6U   .+�5m   *   �� $
 Icon��6;   #��z 5n   ?   $
��Icon��5o   ?   $
��Left=�5p   ?   $��Center=�6Z   $��16��5q   ?   $��16��6K   # z 5r   ?   5s   '   � 5t   &   $ GlyphWrapper��6+   $y�	Collapsed=�6A   $��40��6X   .+�5u   *   (� $ 
GlyphPanel��62   $��16��5v   6   $��16��6A   $
��Left=�5w   6   $��0q�5x   6   $y�	Collapsed=�6A   $��Center=�6X   $��LeftToRight=�5y   6   .��5z   .   �� $��24��65   $��24��6@   .+�5{   2   F� $  Glyph��5|      K����@o@��j �@T� ��!��g5 `�� Ѱ�J �z� Q@T� �Q��+0@�p�*�KU �@o@��j 	#��z��5}      $��LeftToRight=�6?   5~   /   5   +   5�   '   � 5�   &   $��1��6+   .+�5�   *   �� $ BoldHeaderPresenter��6;   $y�Hidden=�5�   ;   $
��Bold"�5�   ;   #��z��5�   ;   #��z��5�   ;   #" z! 5�   ;   $��Header��5�   ;   ��. # z 5�   ;   $��Center=�5�   ;   �� 5�   *   $ HeaderPresenter��6;   #��z��5�   ;   #��z��5�   ;   #" z! 5�   ;   $��Header��5�   ;   ��. # z 5�   ;   $��Center=�5�   ;   5�   '   � 5�   &   $ InputGestureTextWrapper��6+   $��2��5�   /   $y�	Collapsed=�5�   /   .+�5�   *   �� $��16 0 0 0q�5�   8   $��Center=�5�   8   $��Right=�6S   #��z# 5�   8   # z 5�   8   #��z��5�   8   y�5�   4   �� *InputGestureText+8  5�   8   5�   '   � 5�   &   $ SubBlock��6+   $��2��5�   /   $y�	Collapsed=�5�   /   $��16 0 0 0q�5�   /   .+�5�   *   F� $��5��6/   $��10��69   $$ Uniform=�5�   3   $��Right=�5�   3   $��Center=�5�   3   "����     $� � z  z �        	#��z��5�   3    .  5�   3   5�   '   5�   #   5�      5�      � 5�      $% 
PART_Popup��6    & . |�.  $��Slide=�5�       $��Bottom=�5�       ��5�       �� *IsSubmenuOpen+' �� *TemplatedParent+	 5�        5�   "   
 .  . 6E   .��5�      �� $ SubMenuBorder��6%   # � 	 5�   %   $ 2��5�   %   ��5�   %   �� $( 
Background�' �� $) FindAncestor=�$* MenuBaseL�._�5�   "   �� 
������ ._�5�   &   �� $ SubMenuScrollViewer��63   ��6P   C� *�� $ MenuScrollViewer��" �+.��5�   *   � $ Enabled=�6/   $
��0 16q�6U   .+�5�   .   �� $
��Left=�65   $��0��6P   $	��Top=�6[   $��0��6s   .+�5�   2   �� $+ 
OpaqueRect��6<   ��5�   <   �� *
Background+$, SubMenuBorder����5�   <   �� *ActualHeight+$, SubMenuBorder����5�   <   �� *ActualWidth+$, SubMenuBorder��5�   /   �� 5�   .   $ ItemsPresenter��6=   $ Cycle=�5�   =    . # z 5�   =   $ Cycle=�5�   =   5�   +   5�   '   5�   #   5�      5�      5�      - 5�      P� 5�      . �@m�Role$/ SubmenuHeader=�62   . �5�      �� $0 SubBlock��6%    � y�$ Visible=�6Q   �� 5�      $0 
PART_Popup��6%    � ��$ Right=�6R   �� 5�       � ��$ 32��67   �� 5�      $0 BoldHeaderPresenter��6%    � y�$ 	Collapsed=�6\   5�      P� 5�      . �@m�Role$/ SubmenuItem=�62   . �5�      ��  � ��$ 32��67   �� 5�      $0 InputGestureTextWrapper��6%    � y�$ Visible=�6`   �� 5�      $0 BoldHeaderPresenter��6%    � y�$ 	Collapsed=�6\   5�      P� 5�      . �@m�Role$/ TopLevelHeader=�62   . �5�      ��  �@�IsSharedSizeScope . 6G   �� 5�       � ��$
 16 0q�68   �� 5�       � ��$ 48��67   �� 5�      $0 templateRoot��6%    �@��CornerRadius$ 2��6W   �� 5�      $0 BackgroundRoot��6%    �@��CornerRadius$ 2��6Y   5�      P� 5�      . �@m�Role$/ TopLevelItem=�62   . �5�      ��  � ��$
 16 0q�68   �� 5�       � ��$ 48��67   �� 5�      $0 templateRoot��6%    �@��CornerRadius$ 2��6W   �� 5�      $0 BackgroundRoot��6%    �@��CornerRadius$ 2��6Y   5�      ]� 5�      1 5�      �� 5�   "   2 �@m�Role$3 TopLevelHeader=�6<   �� 5�   "   2 �@m�IsSubmenuOpen3 . 6E   /�5�      �� 5�   "   $0 HeaderPresenter��6)    � ��$
 Bold"�6f   5�      P� 5�      $4 
PART_Popup��6;   . �@�HasDropShadow/ . . �5�      �� $0 SubMenuBorder��6%    � ��$ 5q�6R   5�      P� 5�      ". �@m�IsSuspendingPopupAnimation/ . . �5�      �� $0 
PART_Popup��6?    � ��$
 None=�6W   5�      P� 5�      / 62   Z� . �@m�Icon. �5�      �� $0 IconWrapper��6;    � y�$ 	Collapsed=�6T   5�      P� 5      . �@m�	IsChecked/ . . �5     �� $0 
GlyphPanel��6;    � y�$ Visible=�6S   5     P� 5     . �@m�IsCheckable/ . . �5     �� $0 GlyphWrapper��6;    � y�$ Visible=�6U   �� 5     $0 IconWrapper��6;    � y�$ 	Collapsed=�6T   5     P� 5     . �@m�IsHighlighted/ . . �5     �� $0 BackgroundRoot��6%    �@J�Opacity$
 0.13Q�6T   5	     P� 5
     . � {�/ .  . �5     ��  �@J�Opacity$	 .56Q�68   5     P� 5     $4 SubMenuScrollViewer��6>   . � ��/ .  . �5     �� $0 
OpaqueRect��6;    6S   �� *VerticalOffset+$, SubMenuScrollViewer�� �@��Top�� 5     $0 
OpaqueRect��6<    6T   �� *HorizontalOffset+$, SubMenuScrollViewer�� �@��Left5     5     5     5     5     