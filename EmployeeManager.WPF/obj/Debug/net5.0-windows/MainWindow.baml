   M S B A M L   `   `   `  ����N  JEmployeeManager.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EmployeeManager.WPFEmployeeManager.WPF  5   	   K*clr-namespace:EmployeeManager.WPF.ControlsEmployeeManager.WPF.Controls  69   $    EmployeeManager.WPF.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EmployeeManager.WPF     5   	   ?controls*clr-namespace:EmployeeManager.WPF.Controls     69     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)   $��18(�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   0   *EmployeeManager.WPF.Controls.HeaderControl  $��2��6!   � 5   
   $��1��6    5      �� 5      $
��Auto �6    �� 5      .+�5      �� $��Refresh��6   $��10q�6(   ��64   �� *LoadCommand+ �� Mode$ OneWay=��� 5      $��1��6    �� DisplayMemberPath$ 	FirstName��5       ��5      �� *	Employees+$ OneWay=� �� SelectedItem 5      �� *SelectedEmployee+$ TwoWay=�5       5!      � 5$   
   $��1��6   $��1��6   y�5%      �� *IsEmployeeSelected+$ OneWay=�    BooleanToVisibilityConverter �� 	Converter# [   5&      �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      .+�50      �� $��
10 10 10 0q�6   	Firstname67   �� 51      $��1��6   $��10q�6�   ��6#   �� *SelectedEmployee.FirstName+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 52      $��2��6   $��
10 10 10 0q�6%   
Entry Date6E   (  "System.Windows.Controls.DatePicker  53      $��3��6   $��10q�6k      SelectedDate 6&   �� * SelectedEmployee.EntryDateTime+$ TwoWay=�6k   �� 54      $��4��6   $��
10 10 10 0q�6%   
Job Role6C   �� 55      $��5��6   $ RoleName��57      	 �� SelectedValuePath$	 Id��58      $��10q�5:      $��Stretch=�5;      ��56      �� *
JobRoles+$ OneWay=�
 �� SelectedValue
 59      �� *SelectedEmployee.JobRole+$ TwoWay=�5;      �� 5<      $��6��6[   $��Is Coffe Drinker��6h   $��10q�6�    d� 	IsChecked 6   �� *" SelectedEmployee.IsCoffeeDrinker+$ TwoWay=�6�   �� 5=      $��7��6   $
��Save��5?      $��10 10 10 30q�5@      $��Bottom=�5A      $
��Left=�5B      ��5>      �� *SelectedEmployee.SaveCommand+$ OneWay=�5B      5D      5E      5F      