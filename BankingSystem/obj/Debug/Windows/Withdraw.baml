   M S B A M L   `   `   `  ����  BankingSystem$    BankingSystem.Windows.Withdraw   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Вывод средств��5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6D   $	��580��6Z   $	��324��6f    � DataContext 5   	   ��  �� RelativeSource �� *Self+��5	      �� 5
   
    �� ImageSource$@ :/BankingSystem;component/Images/General/GradientLinear.png��6   .��5      � $	��471��6   .+�5   
   � $��-13,-15,-13,159q�6   $��Center=�6(   $	��600��6C   $��Center=�6O   $	��327��6l   ��5      �� 5      $6 0/BankingSystem;component/Images/Client/Table.png��6   .+�5      �� -   5         ��Name$ Accounts��5      $��Center=�6)   $��
55,93,55,0q�6F   $	��Top=�6Z   $	��490��6r   $��55��6~   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�    �� SelectedIndex$ 0��6�   ��6�   Z� ��6�   Z� ��5      �� 5      .R�5      � $��55��6   .+�5      � $��50��6#   $��32��6.   $
��Left=�6:   $	��Top=�6U   $��11,9,0,0q�6m   ��5   "   �� 5   &   $9 3/BankingSystem;component/Images/Client/CardIcon.png��61   5      �� 5      $��14(�6(   $��Счет №��66   
���   �$
��Left=�6W   $	��Top=�6r   $��	72,15,0,0q�6�   6�   �� 5      $��14(�6(   
���   �$
��Left=�6d   $	��Top=�6   $��
130,15,0,0q�6�   ��66   �� 	 �� Path$
	 name�6�   �� 5       $��14(�6(   
���   �$
��Left=�6c   $	��Top=�6~   $��
410,15,0,0q�6�   ��66   �� $		 sum�6�   5"      5$      ��5&      �� 5'      $4 ./BankingSystem;component/Images/Auth/Input.png��6!   5*      �� 5-      $ ��Снять со счета��6   $
��Left=�6-   $��	55,45,0,0q�6H   $	��Top=�6[   
 J� RenderTransformOrigin$
 -0.079,-0.462&�6s   $��18(�6�   $
��Bold"�6�   �� 5.      -   5        $��
Снять��5.      $��Center=�6%   $��401,211,55,0q�6B   $	��Top=�6X   $	��144��6p   $��50��6|   ���	#FF1A9DC3���	#FF1A9DC3$
��Bold"�6�   ��6�   Z� 6�   � 5/      $
��Left=�6   $��50��6.   $��
55,211,0,0q�6:   $	��Top=�6N   $	��328��6f   ��50      �� 51      $4 ./BankingSystem;component/Images/Auth/Input.png��6!   .+�53      �� -   5         ��Name$	 Sum��53      $
��Left=�6'   $��30��6B   $��	10,10,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��308��6�   $��18(�6�   $ ��Сумма в рублях��6�   ���	#7F020F15��6�   Z� ��6�   Z�  �� SelectionBrush 6�   Z� 65  54      �� 55      $��
Сумма��6   $
��Left=�6$   $��
55,168,0,0q�6?   $	��Top=�6S   $
 -0.079,-0.462&�6k   $��18(�6�   $
��Bold"�6�   56      57      58      