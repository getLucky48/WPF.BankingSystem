   M S B A M L   `   `   `  ����  BankingSystem"    BankingSystem.Windows.Client   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$!  Личный кабинет��5   	    � WindowStartupLocation$ CenterScreen=�6     � 
ResizeMode$ NoResize=�6E   $
��1446��6[   $	��930��6h    � DataContext 5   	   ��  �� RelativeSource �� *Self+��5	      �� 5
   
    �� ImageSource$@ :/BankingSystem;component/Images/General/GradientLinear.png��6   .��5      � $
��1440��6   $	��900��6   .+�5   
   � $
��Left=�6   $��76��6*   $��
135,76,0,0q�66   $	��Top=�6J   $	��100��6b   ��5      �� 5      $3 -/BankingSystem;component/Images/Auth/Logo.png��6   5      � 5   
   $
��Left=�6   $	��447��6*   $��832,351,0,0q�67   $	��Top=�6L   $	��608��6d   ��5      �� 5      $6 0/BankingSystem;component/Images/Client/Stats.png��6   5      � 5   
   $
��Left=�6   $	��546��6*   $��135,196,0,0q�67   $	��Top=�6L   $	��770��6d   ��5      �� 5      $6 0/BankingSystem;component/Images/Client/Table.png��6   .+�5      �� -   5         ��Name$ Accounts��5      $
��Left=�6)   $��	45,71,0,0q�6D   $	��Top=�6W   $	��490��6o   $��55��6{   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�    �� SelectedIndex$ 0��6�   ��6�   Z� ��6�   Z� ��5      �� 5      .R�5       � $��55��6   .+�5"      � $��50��6#   $��32��6.   $
��Left=�6:   $	��Top=�6U   $��11,9,0,0q�6m   ��5#   "   �� 5$   &   $9 3/BankingSystem;component/Images/Client/CardIcon.png��61   5&      �� 5(      $��14(�6(   $��Счет №��66   
���   �$
��Left=�6W   $	��Top=�6r   $��	72,15,0,0q�6�   6�   �� 5)      $��14(�6(   
���   �$
��Left=�6d   $	��Top=�6   $��
130,15,0,0q�6�   ��66   �� 	 �� Path$
	 name�6�   �� 5*      $��14(�6(   
���   �$
��Left=�6c   $	��Top=�6~   $��
410,15,0,0q�6�   ��66   �� $		 sum�6�   5,      5.      ��50      �� 51      $4 ./BankingSystem;component/Images/Auth/Input.png��6!   54      �� 57      $��Выбрать счет��6   $
��Left=�6+   $��	45,23,0,0q�6F   $	��Top=�6Y   
 J� RenderTransformOrigin$
 -0.079,-0.462&�6q   $��18(�6�   $
��Bold"�6�   �� 58      -   5        $��Перевести��58      $
��Left=�6)   $��
569,80,0,0q�6D   $	��Top=�6X   $	��140��6p   $��35��6|   ���	#FF1A9DC3���	#FF1A9DC3$
��Bold"�6�   ��6�   Z� 6�   59      �� 5:   
   -   5        $��Открыть счет��5:      $
��Left=�6'   $��
305,93,0,0q�6B   $	��Top=�6V   $��18(�6n    � Cursor$
 Hand��6�   $
��Bold"�6�   �� 5;   
   -   5        $!��Пополнить счет��5;      $
��Left=�6)   $��
482,93,0,0q�6D   $	��Top=�6X   $��18(�6p   $
 Hand��6~   $
��Bold"�6�   6�   �� 5<   
   -   5        $ ��Снять со счета��5<      $
��Left=�6)   $��
676,93,0,0q�6D   $	��Top=�6X   $��18(�6p   $
 Hand��6~   $
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  5=   
   -   5          Name$ Table��5=   A      AutoGenerateColumns .     
IsReadOnly . $
��Left=�6P   $	��308��6k   $��184,375,0,0q�6x   $	��Top=�6�   $	��658��6�      Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Сумма��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� $		 sum�  5B      $0 *Комментарий к переводу��6%   $	 200 6E    6Q   �� $	 descr�  5C      $ Счет списания��6%   $	 175 6<    6H   �� $	 bs_account_name_src�  5D      $# Счет зачисления��6%   $	 175 6>    6J   �� $	 bs_account_name_dist�5I      5K      5L      