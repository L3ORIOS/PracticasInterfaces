   M S B A M L   `   `   `  ����D  @Practica5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Practica5	Practica5  5   	       Practica5.CheckBoxes   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Practica5     5   	     � Title$  
CheckBoxes��5   	   $	��150��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��10q�6   .+�5      �� $
��Bold"�6   .��6&   Opciones Simples68   �� 5      .��6   
Opcion 16!   �� 5       d� 	IsChecked$
 TrueY�6   .��6(   
Opcion 262   �� 5      .��6   
Opcion 36!   5      �� 5   
   $��1��6   $��10q�6%   .+�5      �� $
��Bold"�6   .��6&   Opciones Decoradas6:   �� 5      .��5      �� 	Opcion �� 5      
��� � �$
��Bold"�6%   .�67   ABC6<   5      5      �� 5      $
 TrueY�6   .��5      � .+�5       �� 	Opcion �� 5!      $
��Bold"�6   .�6$   XYZ6)   5"      5$      5%      �� 5&      .��5'      �� 	Opcion �� 5(      
����  � �� TextDecorations$ 	Underline{�6#   $
��Bold"�6?   .�6Q   WWW6V   5)      5*      5+      �� 5-   
   $��2��6   $��10q�6%   .+�5.      �� $
��Bold"�6   .��6&   Opciones Tres Estados6=   �� 5/      -   5         ��Name$ ckbx0��5/      .��6?   Activar todo6M   �� 50      -   5        $ ckbx1��50      ${�False��6&   $��10,0,0,0q�68   .��6J   
Opciones 16V   �� 51      -   5        $ ckbx2��51      ${�False��6&   $��10,0,0,0q�68   .��6J   
Opcion 26T   �� 52      -   5        $ ckbx3��52      ${�False��6&   $��10,0,0,0q�68   .��6J   
Opcion 36T   53      54      55      