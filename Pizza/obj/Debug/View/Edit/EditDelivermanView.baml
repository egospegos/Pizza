   M S B A M L   `   `   `  ����@  <Pizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Pizza.View.EditPizza.View.Edit  5   	   -clr-namespace:Pizza.HelpersPizza.Helpers  5
   	   (    "Pizza.View.Edit.EditDelivermanView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Pizza.View.Edit     5   	   *xcclr-namespace:Pizza.Helpers     5
   	   -   5          �Name$	  ddd��5   
    � Title$  Редактировать��5   	   $	��280��6   $	��400��6,   $��14(�69   $��Roboto)�6G   ���#191970 � WindowStartupLocation$ CenterScreen=�5	      .��5      � ���	#FFEEEEEE � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $
��auto �6   .+�5   
   �� ���#606060$��ФИО курьера��6)   $��0��6<   $��0��6L   $��5,5,2,5q�6Y   $��Bottom=�6j   �� 5   
   $��1��6   ���#606060$��0��67   $��2,5,5,5q�6D   ��6U   ��  �� Path$ CurrentDeliveryman.Name� �� Mode$ TwoWay=��� 5   
   ���#606060$��Телефон��6)   $��0��68   $��1��6H   $��5,5,2,5q�6U   $��Bottom=�6f   �� 5   
   $��1��6   ���#606060$��1��67   $��2,5,5,5q�6D   ��6U   �� $ CurrentDeliveryman.Phone�$ TwoWay=��� 5    
   ���#606060$%��Марка автомобиля��6)   $��0��6A   $��2��6Q   $��5,5,2,5q�6^   $��Bottom=�6o   �� 5!   
   $��1��6   ���#606060$��2��67   $��2,5,5,5q�6D   ��6U   �� $! CurrentDeliveryman.CarBrand�$ TwoWay=��� 5#   
   ���#606060$+��%Автомобильный номер��6)   $��0��6D   $��3��6T   $��5,5,2,5q�6a   $��Bottom=�6r   �� 5$   
   $��1��6   ���#606060$��3��67   $��2,5,5,5q�6D   ��6U   �� $" CurrentDeliveryman.CarNumber�$ TwoWay=��� 5(   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��0��6;   $��2��6K   $��40��6_   $��Center=�6k   .+�5)      �� $��Применить��6   $
��auto��6*   $��5q�68   $��Center=�6C    �� IsCancel . ��6a   �� $ ApplyChangesCommand�6�   �� 5*      $��Отмена��6   $
��auto��6'   $��5q�65   $��Center=�6@    . 6^   5+      5-      5.      