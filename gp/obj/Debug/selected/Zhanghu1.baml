   M S B A M L   `   `   `  ����=  9gp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:gp.selectedgp.selected  5          gp.selected.Zhanghu1   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:gp.selected     5        N� Title$  Zhanghu1��5	      .��5
      � $
��0 10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� 
�������$��Center=�60    �� Orientation$ 
Horizontal=�6M   $��
10,0,4,0.2q�6f   $
��1000��6z   .+�5      �� $��24(�6   $��
欢迎您,��6+   $��350 10 10 0q�67   $��70��6L   
����  �6W   �� 5      -   5        $��username��5   H   $��24(�6   $��用户:��6+   $��0 10 0 0q�66   
����  �6X   �� 5      -   5        $
��text��5      $��34(�6(   
���  ��6K   5      5      � 5   
   $��1��6   $��0 0 0 0q�6    � ColumnDefinitions 5      �� 5      $
��462* �6#   �� 5      $
��539* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
dataggrid1��5   B      CanUserAddRows .  
�������   AutoGenerateColumns .  $
��Left=�5      $	��488��6,   $	��376��68   $	��Top=�6E   ��5   T   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ 股票id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 77 6T   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *
stock_id+6b     5!      $ 股票名称��6)   $ 77 6Q   	 67   �� *name+6^     5"      $ 股票价格��6)   $ 77 6R   	 67   �� *price+6_     5#      $ 持股数量��6)   $ 77 6T   	 67   �� *
num_free+6b     5$      $ 可用数量��6)   $ 77 6U   	 67   �� *
num_free+6b     5%      $ 冻结数量��6)   $ 77 6X   	 67   �� *num_freezed+6e   5)        5*      -   5        $��
dataggrid2��5*   Q    .  $��1��6.   
������� .  $
��Left=�5+      $	��539��6,   $	��400��68   $	��Top=�6E   ��5*   c   ��  5.        5/      $ 创建时间��6)   $ 77 6[   	 67   �� *create_datetime+6i     50      $ 股票名称��6)   $ 77 6Q   	 67   �� *name+6^     51      $ 委托类型��6)   $ 77 6Q   	 67   �� *type+6^     52      $ 委托价格��6)   $ 77 6Q   	 67   �� *price+6_     53      $ 	未成交��6)   $ 77 6T   	 66   �� *
undealed+6a     54      $ 	已成交��6)   $ 77 6R   	 66   �� *dealed+6_     55      $ 	已取消��6)   $ 77 6T   	 66   �� *
canceled+6a   58      5:      5<      5=      