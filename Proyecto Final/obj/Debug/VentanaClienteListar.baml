   M S B A M L   `   `   `  ����  Proyecto Final)    #Proyecto_Final.VentanaClienteListar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$  	frmListar��5   	    � Title$ Listar��5      $	��418��6   $	��527��6!   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��251* �6   �� 5	      $
��213* �6    � RowDefinitions 5   
   �� 5      $	��26* �6   �� 5      $
��115* �6   �� 5      $	��45* �6   �� 5      $
��122* �6   �� 5      $	��65* �6   .+�5   
   �� -   5         ��Name$ lblMostrarPlatillos��5      $,��&Mostrar Platillos (escoger categoría)��6-   $��Center=�6]   $��0q�6z   $��2��6�   $��Center=�6�   $��26��6�   $	��200��6�   �� 5   
   -   5        $ lblMostrarPlatillo��5      $U��OPara Mostrar la información de un platillo dar click sobre el platillo deseado��6,   $��Center=�6�   $��0q�6�   $��4��6�   $��Center=�6�   $��2��6�   �� 5   
   -   5         ��Name$ cbCategorias��5      $��1��6)   $��0q�69   $��2��6D   $��Center=�6Q   $��22��6l   $��Center=�6x   $	��135��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCategorias��5      $��Center=�6)   $��0q�6F   $��Center=�6Q   $��2��6l   $��83��6�   $	��490��6�   $��1��6�      CanUserAddRows .     AutoGenerateColumns .  ��6�   �� *
categorias+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        dataGridTextColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Título��5         
IsReadOnly .    CanUserSort .     CanUserReorder .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *nombre+   ClipboardContentBinding 6\   Z� 6�     5       .  $
 Platillos Ofrecidos��6�    .  6%   �� *platillos_ofrecidos+ 6a   Z� 6�   5        5   
   -   5        $ dgPlatillosPorCategoria��5      $��Center=�64   $��0q�6Q   $��Center=�6\   $��2��6w   $��82��6�   $	��490��6�   $��3��6�    .   .  ��6�   �� *	platillos+	 5        5      $
 Nombre��6c    .  .   .   6%   �� *nombre+ 6@   Z� 6�     5      $
 Restaurante��6n    .  .   .   6%   �� *nombreRestaurante+ 6K   Z� 6�     5       $
 id��6i      
Visibility$ Hidden=�6u    .   .   6%   �� *platillos_id+ 6F   Z� 6�   5"      �� 5#   
   -   5         ��Name$ txtIdPlatillo��5#      $��1��6)   $��Center=�69   $��22��6V   $��18,24,103,19q�6b   $��4��6x    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��120��6�   $y�Hidden=�6�   ��6�   �� *id+6�   �� 5$   
   -	   5         ��Name$ btnRegresar��5$      $��Regresar��6&   $
��Left=�69   $��21,3,0,3q�6T   $��Center=�6f   $��75��6�   5&      5'      