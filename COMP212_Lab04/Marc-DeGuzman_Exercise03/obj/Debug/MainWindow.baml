   M S B A M L   `   `   `  ����S  OMarc-DeGuzman_Exercise03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Marc_DeGuzman_Exercise03Marc_DeGuzman_Exercise03  5   	   )    #Marc_DeGuzman_Exercise03.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Marc_DeGuzman_Exercise03     5   	     � Title$   Restaurant Bill Calculator��5   	   $��522.029��6,   $��512.244��6=   .��5	      � ���	#FF4194E6$��0,0,2,0q�6"   $	��490��63   $	��Top=�6@   .+�5
   
   �� -   5        $��mainStatusBar��5
      $
��Left=�6)   $��37��6D   $��244,443,0,0q�6P   $	��Top=�6e   $	��248��6}   ���	#FF4D6A01.@�5      �� -   5        $��logoStatusBar��5      $"��.\Images\centennial_logo.jpg��6)   $	��114��6O   $��36��6�   �� 5      -   5        $��nameStatusBar��5      $��Marc De Guzman��6)   $	��125��6B   $��37��6N   $��14(�6Z   $��Center=�6h   ���	#FF4AC14A6�   5      �� 5   
   $��Beverage��6   $
��Left=�6#   $��	10,20,0,0q�6>   $	��Top=�6Q   $��30��6i   $��93��6u   $��14(�6�   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   $��	Appetizer��6   $
��Left=�6$   $��	10,55,0,0q�6?   $	��Top=�6R   $��30��6j   $��93��6v   $��14(�6�   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   $��Main Course��6   $
��Left=�6&   $��	10,90,0,0q�6A   $	��Top=�6T   $��30��6l   $��93��6x   $��14(�6�   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   $��Dessert��6   $
��Left=�6"   $��
10,125,0,0q�6=   $	��Top=�6Q   $��30��6i   $��93��6u   $��14(�6�   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   -   5        $��
cbBeverage��5      $
��Left=�6%   $��
108,20,0,0q�6@   $	��Top=�6T   $	��153��6l   $��14(�6x   $��30��6�   6�   �� 5   
   -   5         ��Name$ cbAppetizer��5      $
��Left=�6(   $��
108,55,0,0q�6C   $	��Top=�6W   $	��153��6o   $��14(�6{   $��30��6�   6�   �� 5   
   -   5        $ cbMainCourse��5      $
��Left=�6)   $��
108,90,0,0q�6D   $	��Top=�6X   $	��153��6p   $��14(�6|   $��30��6�   6�   �� 5   
   -   5        $ 	cbDessert��5      $
��Left=�6&   $��108,125,0,0q�6A   $	��Top=�6V   $	��153��6n   $��14(�6z   $��30��6�   6�   �� 5   
   $��
Sub Total:��6   $
��Left=�6%   $��
315,20,0,0q�6@   $	��Top=�6T   $��30��6l   $��74��6x   $��14(�6�   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   $
��Tax:��6   $
��Left=�6   $��
315,55,0,0q�6:   $	��Top=�6N   $��30��6f   $��74��6r   $��14(�6}   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   $��Total:��6   $
��Left=�6!   $��
315,90,0,0q�6<   $	��Top=�6P   $��30��6h   $��74��6t   $��14(�6   $
��Bold"�6�   ���	#FF2DA26D6�   �� 5   
   -   5        $��labelSubTotal��5      $��$0.00��6%   $��Right=�65   $��	0,20,34,0q�6Q   $	��Top=�6d   $��30��6|   $��74��6�   $��14(�6�   $
��Bold"�6�   ���	#FF93EEB4$��Right=�6�   �� 5   
   -	   5         ��Name$ labelTax��5      $��$0.00��6"   $��Right=�62   $��	0,55,34,0q�6N   $	��Top=�6a   $��30��6y   $��74��6�   $��14(�6�   $
��Bold"�6�   ���	#FF93EEB4$��Right=�6�   �� 5   
   -
   5        $ 
labelTotal��5      $��$0.00��6$   $��Right=�64   $��	0,90,34,0q�6P   $	��Top=�6c   $��30��6{   $��74��6�   $��14(�6�   $
��Bold"�6�   ���	#FF93EEB4$��Right=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgBillItems��5         AutoGenerateColumns .  $
��Left=�6D   $	��252��6_   $��
10,178,0,0q�6l   "   VerticalScrollBarVisibility$
 Auto=�5    +      CanUserAddRows .     RowBackground
 �����$	��Top=�5"      $	��351��6+      GridLinesVisibility$	 All=�67   ��5       �� 	   Columns	 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6L      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6W     5%      $
 Category��6%   $	 120 6T    .  67   �� *
Category+6`     5&      $
 Price��6%   $ 80 6d    .  64   �� *Price+ �� StringFormat$
 ${0}��6o     5'      $
 Quantity��6%   $ * 6a    .   67   �� *
Quantity+ �� Mode$ TwoWay=�6k   5)      �� 5*   
   -   5        $��Remove Item��5*      $
��Left=�6'   $��366,353,0,0q�6B   $	��Top=�6W   $	��102��6o   $��36��6{   $��14(�6�   ���	#FFC4E25D6�   �� 5+   
   -   5        $��
Clear Bill��5+      $
��Left=�6&   $��366,394,0,0q�6A   $	��Top=�6V   $	��102��6n   $��36��6z   $��14(�6�   ���	#FFC4E25D6�   5-      5.      