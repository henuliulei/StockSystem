   M S B A M L   `   `   `  ����=  9gp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:gpgp  5   	       gp.LoginWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:gp     5   	     � Title$  LoginWindow��5   	   $	��500��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�68   .��5	      � $��0,0,-0.4,-0.6q�6   ��5
   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ images/a3.jpg��6(   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��        账户:��6   $��40(�6*   
����  �$
��Left=�6J   $��
128,54,0,0q�6e   $	��Top=�6y   $	��200��6�    J� RenderTransformOrigin$ 0.253,0.591&�6�   �� 5      -   5        $��userTb��5   $   $��35(�6   $��20,54,83.4,18.6q�6<    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��320��6�   $��50��6�   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��        密码:��6   $
��Left=�6*   
����  �$��40(�6W   $��128,137,0,0q�6e   $	��Top=�6z   G� 5      -   5        $��
passwordTb��5   9   $��35(�6    G� PasswordChar$ *��6(   $	��320��6K   $��50��6W   $��26,21,23.4,155.6q�6c   �� 5      -   5        $��passwordLook��5      $
��Left=�6+   $��23��6F   $��	89,91,0,0q�6R   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   $y�Hidden=�6�   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5        $��enterBtn��5   ,   $��30(�6<   $
��Left=�6J   $��290,243,0,0q�6e   $	��100��6z   $��50��6�   $	��Top=�6�   ��6   Z� .��6�   登陆5      �� 5      -   5        $��registerBtn��5      $
��Left=�6?   $��50��6Z   $��156,243,0,0q�6g   $	��Top=�6|   $��30(�6�   $	��100��6�   ��6)   Z� .��6�   注册5      5       5$      5%      