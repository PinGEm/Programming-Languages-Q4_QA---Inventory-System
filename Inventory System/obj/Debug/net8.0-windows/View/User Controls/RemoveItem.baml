   M S B A M L   `   `   `  ����K  GInventory System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Inventory_SystemInventory_System  5      Y1clr-namespace:Inventory_System.View.User_Controls#Inventory_System.View.User_Controls  5      4    .Inventory_System.View.User_Controls.RemoveItem   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .srcclr-namespace:Inventory_System     5      Clocal1clr-namespace:Inventory_System.View.User_Controls     5      .��5
      �   � RowDefinitions  5   
   �� 5      $��0.20* �6   �� 5      $��0.80* �6   .+�5   
   �� $��Current Inventory:��6   
�������$��30(�6A   $��Center=�6O   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��0.25* �6#   �� 5      $��0.55* �6#   �� 5      $��0.20* �6#   .+�5      �� $&�� Enter Index/Name to Remove Item:��6   
�������$��0,0,0,60q�6S   $��Center=�6e   $��24(�6�   $
��Wrap=�5       �� TextAlignment$ Center=�6,   �� 5      -   5         ��Name$ tb_input��5   <   $	��180��6   $��34��6"   $��24(�6.   6P   �� 5      -   5        $��20��5      $��Remove Item��6!   $	��100��67   $��Bottom=�6C   $��0,0,0,50q�6^   6p   �� 5      -   5        $��20��5      $��	Clear All��6!   $	��100��65   $��Bottom=�6A   $��0,0,0,20q�6\   6n   �� 5       -   5         ��Name$ 
ErrorPopup��5!   /   $�� ��5       $��2��6    
���  ��$��20(�6A   $��Center=�6O   $
��Wrap=�6l   $ Center=�5!      6/   �� 5"      -   5        $ ConfirmPopup��5#   /   $�� ��5"      $��2��6    
��� � �$��20(�6C   $��Center=�6Q   $
��Wrap=�6n   $ Center=�5#      6/   �� 5'      -   5         ��Name$ inventoryList��5'      $��1��6.   ���#1a1a1a$��0q�6S   $��	0,20,0,30q�6g    K� ZIndex$ 1��6z   $	��250��5(      $	��Top=�6   ��64   �� *Items+ �� View 5)      �� 5*      .P�5+      ��  �� Width$	 100��6)   $��Index��65   	 �� DisplayMemberBinding	 6D   �� *Index+
 �� HeaderContainerStyle
 5,      �� 5-   "    �� 
TargetType" ��6(   .�5.   &   ��  �� Property � �� �� Value �#4d4d4d6C   �� 5/   &    � �� �#4d4d4d6D   �� 50   &    � ��
 �����6C   51   #   53      �� 54      $	 350��6)   $��Name of Item��65   	 6K   �� *
ItemName+
 55      �� 56   "   " ��6(   .�57   &   ��  � �� �#4d4d4d6C   �� 58   &    � �� �#4d4d4d6D   �� 59   &    � ��
 �����6C   5:   #   5<      5=      ��5@      �� 5A      " ��6   �5B      �� 5C       � ��
 �����6;   5E      5G      5H      5I      5J      