   M S B A M L   `   `   `  ����@  <Pizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PizzaPizza  5   	       Pizza.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Pizza     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1024��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5	      � -   5        ���	#FFEEEEEE.+�5   
   �� $��250,51,0,10q�6   $��3��6,   .��5      �� .+�5      � $
��auto��6   .+�5      � -   5         �Name$ GridPrincipal��5      $��Center=�62   $	��Top=�6O   5      5      5      �� 5   
   $	��Top=�6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$ 1Q�6#      	Direction$	 330Q�6/      
BlurRadius$ 50Q�6?      Color$ 	#FFDEDEDE��6O   	   ShadowDepth$	 1Q�6a   .+�5      � ���#e53835$��10��6(   � 5      $��	254,5,5,5q�6   ���	#FFEEEEEE.+�5      �� -   5        
 ��Name$
 ButtonClose��5      $��30��6.   $��30��69   $��Right=�6[   $	��Top=�6w   $��0q�6�   
���  �� J� Opacity$	 0.6Q�6�   ��6E   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ CloseBox=�6.   $��30��6>   $��30��6I   5      �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��GO GO PIZZA��6    $��Center=�64   $��30(�6O   ���#e53835$��Goudy Stout)�6r   $
��20 0q�6�   5      �� 5      $ 
Horizontal=�6%   $��Right=�6>   $
��10 0q�6Z   5       5!      �� 5"   
   $��Bottom=�6   .+�5#      � ���#e53835$��10��6(   5$      � 5%   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5&      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5&   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5'      � -   5        $ 
GridCursor��5'      $��	0 100 0 0q�6+   ���#e53835$��10��6S   $
��Left=�6^   $��60��6y   $	��Top=�6�   5(      �� 5)      -   5         ��Name$ ListViewMenu��5)      $��0 100q�6-   
�������$��Champagne & Limousines)�6S   $��18(�6{    �� SelectedIndex$ 0��6�   .@�5*      �� -   5        $��60��5*      .��5+      �� $ 
Horizontal=�6!   .+�5,        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5-      $��
Домой��6$   $��17(�61   $��Center=�6?   $
��20 0q�6Z   5.      5/      �� 50      $��60��6   .��51      �� $ 
Horizontal=�6!   .+�52        $ Pizza=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 53      $��Меню��6$   $��17(�60   $��Center=�6>   $
��20 0q�6Y   54      55      �� 56      $��60��6   .��57      �� $ 
Horizontal=�6!   .+�58        $ FormatListBulleted=�62   $��30��6L   $��30��6W   $��Center=�6c   $��5q�6~   �� 59      $!��Список заказов��6$   $��17(�6:   $��Center=�6H   $
��20 0q�6c   5:      5;      �� 5<      $��60��6   .��5=      �� $ 
Horizontal=�6!   .+�5>        $ 	TruckFast=�62   $��30��6C   $��30��6N   $��Center=�6Z   $��5q�6u   �� 5?      $��База курьеров��6$   $��17(�69   $��Center=�6G   $
��20 0q�6b   5@      5A      �� 5B      $��60��6   .��5C      �� $ 
Horizontal=�6!   .+�5D        $ Information=�62   $��30��6E   $��30��6P   $��Center=�6\   $��5q�6w   �� 5E      $��О программе��6$   $��17(�67   $��Center=�6E   $
��20 0q�6`   5F      5G      �� 5H      $��60��6   .��5I      �� $ 
Horizontal=�6!   .+�5J        $ Logout=�62   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 5K      $��Авторизация��6$   $��17(�67   $��Center=�6E   $
��20 0q�6`   5L      5M      5O      5P      5R      5S      