   M S B A M L   `   `   `  ����H  DPracticaFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PracticaFinalPracticaFinal  5   	       PracticaFinal.Recuperar   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PracticaFinal     5   	   -   5          � Title$  	Recuperar��5   	   $	��600��6   $
��1000��6(   
������  � WindowStyle$
 none=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � Icon$ /Group-4.ico��5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ DictionaryOfStyles.xaml?�6%   %    5      .��5      � .+�5   
   ��  �� CornerRadius$ 20��6      Rojo#��[  6#   $��5q�6F   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$

 0 ,1&�67   .��5      �  � Color$ #FF4B3A��6#    � Offset$ 1Q�63   6@   � 5      $ #FFFFFF��6#   $
 0.75Q�63   6C   � 5      $ #00F4EF��6#   $	 0.0Q�63   6B   5      ._�5       �  � ColumnDefinitions 5!      �� 5"      �� 5#       � RowDefinitions 5%      �� 5&      $��30 �6$   �� 5'      .+�5)      �� $��1��6   $��Bottom=�6*   .+�5*      �� $��Bienvenidos��6   $��65(�62   $
��Bold"�6@   
�������$��
Montserrat)�6e   $��	50,0,0,50q�6}   �� 5+      $��/Group 4.png��6   5,      �� 5-      $��1��6   $��1��6-   $	��435��6;   $��100,0q�6H   .+�5.      �� $��Recuperar contraseña��6    $��0,50,0,0q�6=   $��24(�6O     TextBlockStyles#��[ 6]   �� 5/      $��Email address��6    $��	0,50,0,10q�66   #��[ 6I   �� 50      -   5         ��Name$ TextBoxRecuperar��50        TextBoxStyles#��[ 68   6_   �� 51      -   5        $��	ErrorText��51       $ ��* No es un correo válido.��61   $
��0,10q�6R     	ErrorText#��[ 6`   �� 52      $J��DAl hacer click en enviar, recibirá un email con los pasos a seguir.��6    $
��Wrap=�6k   $��	0,50,0,50q�6   #��[ 6�   �� 55      -   5         ��Name$ BtnRecuperar��55      $��Enviar��63   ${�False��6D     
ButtonClik#��[ 6W   6{   56      �� 57       �� Orientation$ 
Horizontal=�6   .+�58      �� -   5        $��/Arrow 1.png��58      $��20��62   $��20��6=   $
��20,0q�6I    � Cursor$
 Hand��6s   �� 59      $��Volver��6    #��[ 6.   $��0,5,0,0q�6W   5:      �� 5;      $��1��6   $ 
Horizontal=�6-   $��Right=�6F   .+�5<      �� -   5        $ btn_Minimizar��5<      $��-��64     ControlesDeVentana#��[ 6@   6l   �� 5=      -   5        $ 
btn_Cerrar��5=      $��x��61   #��[ 6=   6i   5>      5?      5@      5A      5B      