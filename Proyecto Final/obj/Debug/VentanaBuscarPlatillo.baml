   M S B A M L   `   `   `  ����  Proyecto Final*    $Proyecto_Final.VentanaBuscarPlatillo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  VentanaBuscarPlatillo��5      $	��322��6#   $	��359��60   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��58* �6   �� 5      $	��55* �6    � RowDefinitions 5
   
   �� 5      $	��32* �6   �� 5      $	��17* �6   �� 5      $	��67* �6   �� 5      $
��112* �6   �� 5      $	��42* �6   .+�5   
   �� -   5         ��Name$ lblIngreseNombre��5      $?��9Ingrese el nombre o la descripción del platillo a buscar��6*   $��Center=�6m   $��Center=�6�   $��2��6�   $	��330��6�   $��26��6�   $��	0,28,0,62q�6�   $��3��6�   �� 5   
   -   5         ��Name$ txtBusqueda��5      $��Center=�6'   $��24��6D   $��0q�6P   $��2��6[    �� TextWrapping$
 Wrap=�6h   $��Center=�6|   $	��148��6�   �� 5   
   -   5         ��Name$ 	btnBuscar��5      $��Buscar��6$   $��1��65   $��Center=�6E   $��43,23,43,24q�6b   $��2��6w   $��Center=�6�   $��75��6�   $��20��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgPlatillosBusqueda��5      $��Center=�60   $
��6,11q�6M   $��Center=�6[   $��2��6v   $��90��6�   $	��318��6�   $��3��6�      AutoGenerateColumns .  	   CanUserAddRows	 .  ��6�   �� *	platillos+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6c      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *nombre+   ClipboardContentBinding 6@   Z� 6s     5      $ Restaurante��6n    .  6%   �� *nombreRestaurante+ 6K   Z� 6�     5      $ id��6i      
Visibility$ Hidden=�6u    6%   �� *platillos_id+ 6F   Z� 6u   5      �� 5   
   -   5        $ 
lblDeClick��5      $C��=Para más información, de doble click en el platillo deseado��6$   $��Center=�6j   $	��3,8q�6�   $��4��6�   $��Center=�6�   $��2��6�   $	��324��6�   $��26��6�   �� 5   
   -   5        $ txtIdPlatillo��5      $��1��6)   $��Center=�69   $��22��6V   $��	21,6,20,4q�6b   $
 Wrap=�6u   $��Center=�6�   $	��120��6�   $y�Hidden=�6�   ��6�   �� *id+6�   �� 5   
   -   5        $ btnRegresar��5      $��Regresar��6&   $��Center=�69   $��	10,4,84,8q�6V   $��Center=�6i   $��75��6�   $��20��6�   5      5       