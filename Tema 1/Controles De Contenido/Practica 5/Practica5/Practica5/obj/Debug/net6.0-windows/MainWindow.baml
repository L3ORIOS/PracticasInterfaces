   M S B A M L   `   `   `  ����D  @Practica5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Practica5	Practica5  5   	       Practica5.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Practica5     5   	     � Title$#  Practica 5 - Leo Rios 2 - DAM��5   	   $	��300��6/   $	��800��6<    � 	Resources 5
         TogleeButtonStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  &	        �� 5   
   " d�6*   .�5      ��  � ��$ Encender��6(   �� 5       � ��
 �����6+   �� 5       � ��
 �  ��6+   �� 5       � ��
 �  ��6+    5      P� 5       �@d�	IsChecked$
 TrueY�6/   . �5      ��  � ��$ Apagar��60   �� 5       � ��
 � � �63   �� 5       � ��
 �����63   5      5      5      .��5      �  � ColumnDefinitions 5    
   �� 5#      $��* �6   6+   �� 5$      $��* �6   6+   �� 5%      $��* �6   6+   	 � RowDefinitions	 5)   
   �� 5*      $��* �6   6)   �� 5+      $��* �6   6)   .+�50   
   �� $��10q�6   ���	#FFEBEC93
 J� Effect
 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         Color$ 	LightGray��6#      	Direction$	 220Q�65   .+�56      ��  �� Left$ 35��6   
 �� Top$ 35��6%   .��66   Ejemplo de Dialog con botones6U   �� 58      -   5         ��Name$ 
btn_Dialog��58      $ 94��6)   $ 71��6:   .��6d   Pincha aquí
 5:        5;      5=      5>      �� 5A   
   $��1��6   $��10q�6!   ���	#FF2A86C1
 5B        5C      $ 	LightGray��6#   $	 220Q�65   .+�5F      �� $ 34��6   $ 35��6%   $#��Ejemplo de Repeat con botones��65   �� 5G      -   5        $ 
btn_Repeat��5G      $ 91��6)   $ 66��6:   $��Pincha aquí��6J   
 5H        5I      5K      5L      �� 5O   
   $��2��6   $��10q�6!   ���	#FFDEB05D
 5P        5Q      $ 	LightGray��6#   $	 220Q�65   .+�5S      �� $ 35��6   $ 35��6%   $#��Ejemplo de Toggle con botones��65   d� 5T      -   5         d�Name$ btnShowToggle��5T      $ 97��62   $ 66��6C   #��[  6S   
 5U        5V      5X      5Y      �� 5\   
   $��1��6   $��10q�6   ���	#FFEFA2EC
 5]        5^      $ 	LightGray��6#   $	 220Q�65   .+�5`      �� $ 56��6   $ 35��6%   $��Ejemplo de CheckBoxes��65   �� 5a      -   5        $ btn_CheckBoxes��5a      $ 91��6-   $ 71��6>   .��6k   Pincha aquí
 5c        5d      5f      5g      �� 5j   
   $��1��6   $��2��6   $��10q�6.   ���	#FFA2EFC6
 5k        5l      $ 	LightGray��6#   $	 220Q�65   .+�5n      �� $ 56��6   $ 35��6%   $��Ejemplo de RadioButtons��65   �� 5o      -   5        $ btnRadioButton��5o      $ 91��6-   $ 71��6>   .��6m   Pincha aquí
 5q        5r      5t      5u      5x      5y      