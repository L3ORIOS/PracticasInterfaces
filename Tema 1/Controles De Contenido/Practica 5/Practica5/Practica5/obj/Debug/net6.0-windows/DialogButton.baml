   M S B A M L   `   `   `  ����D  @Practica5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Practica5	Practica5  5   	       Practica5.DialogButton   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Practica5     5   	     � Title$  DialogButton��5   	   $	��200��6   $	��400��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��auto �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��/dialog.jpg��6   $��2��6%   $	��100��66   �� 5   
   -   5        $��lbl_pregunta��5   (   $
��Wrap=�6   $��1��6<   $0��*Si quieres cerra la ventana pulsa Cancelar��6L   $��Center=�6~   $��Center=�6�   � 5   
   $��2��6   $��2��6!   $��Right=�61   $��10q�6M   .+�5      �� -   5        $��btn_dialog_ok��5   &    �� 	IsDefault$
 True��6   $��60��6<   $��10q�6J   .��6r   OK6v   �� 5       �� IsCancel$
 True��6   $��60��6%   $��10q�63   .��6?   
Cancelar6I   5      5      5      