   M S B A M L   `   `   `  ����K  GInventory System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Inventory_SystemInventory_System  5      Y1clr-namespace:Inventory_System.View.User_Controls#Inventory_System.View.User_Controls  5      7    1Inventory_System.View.User_Controls.ViewInventory   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .srcclr-namespace:Inventory_System     5      Clocal1clr-namespace:Inventory_System.View.User_Controls     5      $	��380��5	      .��5      �   � RowDefinitions  5   
   �� 5      $��0.25* �6   �� 5      $��0.75* �6   .+�5   
   �� $��Current Inventory:��6   
�������$��30(�6A   $��Center=�6O   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��0.25* �6#   �� 5      $��0.60* �6#   �� 5      $��0.25* �6#   .+�5      �� -   5         ��Name$ inventoryList��5      $��1��6.   ���#1a1a1a$��0q�6S   $��	0,20,0,30q�6g    K� ZIndex$ 1��6z   $	��200��5      $	��Top=�6$   ��6<   �� *Items+ �� View 5      �� 5      .P�5      ��  �� Width$	 100��6)   $��Index��65    �� DisplayMemberBinding 6D   �� *Index+ �� HeaderContainerStyle 5      �� 5   "    �� 
TargetType" ��6(   .�5    &   �� 	 �� Property	 � ��
 �� Value
 �#4d4d4d6C   �� 5!   &   	 � ��
 �#4d4d4d6D   �� 5"   &   	 � ��

 �����6C   5#   #   5%      �� 5&      $	 350��6)   $��Name of Item��65    6K   �� *
ItemName+ 5'      �� 5(   "   " ��6(   .�5)   &   �� 	 � ��
 �#4d4d4d6C   �� 5*   &   	 � ��
 �#4d4d4d6D   �� 5+   &   	 � ��

 �����6C   5,   #   5.      5/      ��52      �� 53      " ��6   �54      �� 55      	 � ��

 �����6;   57      59      5<      5=      5>      