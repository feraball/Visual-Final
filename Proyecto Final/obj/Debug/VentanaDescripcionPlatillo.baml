   M S B A M L   `   `   `  ����  Proyecto Final/    )Proyecto_Final.VentanaDescripcionPlatillo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$  frmDescripPlatillo��5   	    � Title$  VentanaDescripcionPlatillo��5      $��300.7��6(   $	��527��67   .��5      �  � RowDefinitions 5   
   �� 5      $	��11* �6   �� 5      $	��35* �6   �� 5	      $	��44* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgDescripcionPlatillo��5      $��12,22q�62   $��Center=�6A   $��88��6\   $	��495��6h      AutoGenerateColumns .  $��Center=�6�   $��2��6�      
IsReadOnly .    CanUserAddRows .  ��6�   �� *	platillos+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6m   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *platillos_nombre+   ClipboardContentBinding 6J   Z� 6}     5      $ Temperatura��6h   	 . 
 6%   �� *temperatura+ 6E   Z� 6}     5      $
 Tipo��6a   	 . 
 6%   �� *tipo+ 6>   Z� 6o     5      $ 
Categoría��6n   	 . 
 6%   �� *categorias_nombre+ 6K   Z� 6�     5      $ Restaurante��6p   	 . 
 6%   �� *restaurantes_nombre+ 6M   Z� 6�   5      �� 5   
   -   5         ��Name$ btnRegresar��5      $��Regresar��6&   $
��Left=�69   $��	12,10,0,0q�6T   $	��Top=�6g   $��75��6   �� 5   
   -   5         ��Name$ imgPlatillo��5      $
��Left=�6%   $	��105��6@   $��12,0,0,0q�6M   $	��Top=�6_   $	��495��6w   $��1��6�   5      5      