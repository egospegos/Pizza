   M S B A M L   `   `   `  ����@  <Pizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pizza.View
Pizza.View  5          Pizza.View.OrderView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Pizza.View     5      .��5	      � -   5          �Name$  
SupplyGrid��5	      $	��535��6?   $	��800��6L    � DataContext 6   �� *	OrderVM+��5
   
   �� 5       �� ImageSource$ /Pictures/love.jpg��6    �� Opacity$	 0.2Q�6:    j� Stretch$ UniformToFill=�6H   .+�5   
   � $��10q�6    � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      $��40 �6    6.   �� 5      $��2* �6    6.   .+�5      �� $��0��6   $��Center=�6"   $��Roboto)�6?   $��30(�6S   
���  ��.��6r   Заказы J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6'      Color$ 	#FFD49595��67   6K   5      �� 5      -   5        	 ��Name$	 ListViewMain��5      $��Roboto)�6-   $��14(�6A   $��2��6O   ��6\   �� 
 �� Path$
 OrderSource� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� $
 SelectedOrder�$ PropertyChanged=� �� View 5      �� 5      -   5        SupplyGridView��.P�5      �� $��
Пицца��6)    �� DisplayMemberBinding 68   �� $
 
Pizza.Name��� 5      $��Количество��6)    6=   �� $
 Count��� 5      $��Курьер��6)    69   �� $
 Order.Deliveryman.Name��� 5      $#��Телефон курьера��6)    6B   �� $
 Order.Deliveryman.Phone��� 5       $��Дата��6)    67   �� $
 Order.DeliveryTime� �� StringFormat$ d���� 5!      $��Стоимость��6)    6<   �� $

 Cost��� 5"      $��Клиент��6)    69   �� $
 Order.ClientName��� 5#      $#��Телефон клиента��6)    6B   �� $
 Order.ClientPhone��� 5$      $��
Адрес��6)    68   �� $
 Order.Adress�5%      5'      � 5(      $��1��6    � ColumnDefinitions 5)      �� 5*      6)   �� 5+      6)   .+�5-      ��  �� Orientation$ 
Horizontal=�6   $��0��66   $��5q�6F   $
��Left=�6Q   .+�5.      �� $��Добавить��6   ��62   �� $
 AddOrderCommand��� 5/      $��Изменить��6   ��62   �� $
 UpdateOrderCommand��� 50      $��Удалить��6   ��60   �� $
 DeleteOrderCommand�51      52      53      54      55      