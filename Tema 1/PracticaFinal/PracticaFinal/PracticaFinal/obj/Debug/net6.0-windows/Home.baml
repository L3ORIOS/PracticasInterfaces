   M S B A M L   `   `   `  ����H  DPracticaFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PracticaFinalPracticaFinal  5   	       PracticaFinal.Home   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PracticaFinal     5   	   -   5          � Title$
  Home��5   	   $	��600��6   $
��1000��6#   
������  � WindowStyle$
 none=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � Icon$ /Group-4.ico��5   	    � 
ResizeMode$ NoResize=�6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ DictionaryOfStyles.xaml?�6%   %    5      .��5      � .+�5   
   �� 	 �� CornerRadius$	 20��6      Rojo#��[  6#   $��5q�6F   ��5      �� 5      
 �� 
StartPoint$	
 0,0&�6&    �� EndPoint$
 0 ,1&�67   .��5      �  � Color$ #FF4B3A��6#    � Offset$ 1Q�63   6@   � 5      $ #FFFFFF��6#   $
 0.75Q�63   6C   � 5      $ #00F4EF��6#   $	 0.0Q�63   6B   5      ._�5      �  � ColumnDefinitions 5      �� 5       �� 5!       � RowDefinitions 5#      �� 5$      $��30 �6$   �� 5%      .+�5'      �� $��1��6   $��Bottom=�6*   .+�5(      �� $��Bienvenidos��6   $��65(�62   $
��Bold"�6@   
�������$��
Montserrat)�6e   $��	50,0,0,50q�6}   �� 5)      $��/Group 4.png��6   5*      �� 5+      $��1��6   $��1��6*   $��Center=�6:   $��Center=�6W   .+�5,      �� $��Ficha de Usuario��6    $��0,0,0,20q�69   $��24(�6K     TextBlockStyles#��[ 6Y   �� 5-      $��Nombre:��6    #��[ 6/   �� 5.      -   5         ��Name$ 
TextNombre��5.       �� 5/      $��	Apellido:��6    #��[ 61   $��0,10,0,0q�6Z   �� 50      -   5        $ TextApellido��50       �� 51      $��Fecha de nacimiento:��6    #��[ 6<   $��0,10,0,0q�6e   �� 52      -   5        $ 	TextFecha��52       �� 53      $��Comida Favorita:��6    #��[ 68   $��0,10,0,0q�6a   �� 54      -   5        $ 
TextComida��54       �� 55      $��Email:��6    #��[ 6.   $��0,10,0,0q�6W   �� 56      -   5        $ 	TextEmail��56       �� 57      $��Contraseña:��6    #��[ 63   $��0,10,0,0q�6\   �� 58      -   5        $ TextPassword��58       �� 59      $��Sexo:��6    #��[ 6-   $��0,10,0,0q�6V   �� 5:      -   5        $ TextSexo��5:       �� 5;      $��Comunicaciones deseadas:��6    #��[ 6@   $��0,10,0,0q�6i   �� 5<      -	   5        $ TextComunicaciones��5<       �� 5=      -
   5        $��Cerrar Aplicacíon��5=      $��Center=�69   $	��300��6V   $��0,20,0,0q�6b     
ButtonClik#��[ 6�   5>      �� 5@       �� Orientation$ 
Horizontal=�6   .+�5A      �� -   5        $��/Arrow 1.png��5A      $��20��62   $��20��6=   $
��20,0q�6I    � Cursor$
 Hand��6s   �� 5B      $��Volver��6    #��[ 6.   $��0,5,0,0q�6W   5C      �� 5E      $��1��6   $ 
Horizontal=�6-   $��Right=�6F   .+�5F      �� -   5         ��Name$ btn_Minimizar��5F      $��-��64     ControlesDeVentana#��[ 6@   6l   �� 5G      -   5        $ 
btn_Cerrar��5G      $��x��61   #��[ 6=   6i   5H      5I      5J      5K      5L      