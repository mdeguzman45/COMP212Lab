   M S B A M L   `   `   `  ����S  OMarc-DeGuzman_Exercise01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Marc_DeGuzman_Exercise01Marc_DeGuzman_Exercise01  5   	   )    #Marc_DeGuzman_Exercise01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Marc_DeGuzman_Exercise01     5   	     � Title$  Painter Application��5   	   $	��365��6%   $	��350��62   
�������.��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��238* �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ paintCanvas��5      $��1��6&   
�������$��0q�5   
   $��2��5   >   �� 5   
   $��3q�6   .+�5      �� $��Color��6   $��3q�6&   .��5      �� $��3q�6   $
��Left=�6(   $	��Top=�5      .+�5"      	� -   5         	�Name$ redRadioButton��5"   "   $	��Red��6:   $��3q�5#       d� 	IsChecked$
 TrueY�6   6/   	� 5$      -   5        $ blueRadioButton��5$   "   $
��Blue��6;   $��3q�5%      6   	� 5'      -   5        $ greenRadioButton��5'   "   $��Green��6<   $��3q�5(      6   	� 5*      -   5        $ blackRadioButton��5*   "   $��Black��6<   $��3q�5+      6   5,      5-      �� 50      $
��Size��6   $��3q�6%   .��51      �� $��3q�6   $
��Left=�6(   $	��Top=�52      .+�53      	� -   5        $ smallRadioButton��53   "   $��Small��6<   $��3q�54      $
 TrueY�6   6/   	� 55      -   5        $ mediumRadioButton��55   "   $
 TrueY�6=   $��Medium��56   7   $��3q�57      	� 58      -   5        $ largeRadioButton��58   "   $
 TrueY�6<   $��Large��59   6   $��3q�6F   5:      5;      �� 5>      -	   5         ��Name$ 
undoButton��5>      $
��Undo��6)   $��75��68   $��3,10,3,3q�5?      6   �� 5B      -
   5        $ clearButton��5B      $��Clear��6*   $��75��6:   $��3,10,3,3q�5C      6   �� 5F      -   5        $ 
exitButton��5F      $
��Exit��6)   $��75��68   $��3,10,3,3q�5G      6'   5H      5I      5J      