   M S B A M L   `   `   `  ����  Proyecto Final2    ,Proyecto_Final.VentanaPlatilosPorRestaurante   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$  frmVentanaPlatillos��5   	    � Title$ Platillos por Restaurante��5      $	��300��6'   $��510.879��64   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgPlatillosPorResta��5      $��10,64,36,70q�61      AutoGenerateColumns .     EnableRowVirtualization .  ��6F   ��  �� Path$ 	platillos�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5	      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *nombre+6A     5
      $ Temperatura��6F    6%   �� *temperatura+6F     5      $
 Tipo��6?    6%   �� *tipo+6?     5      $ 	Categoria��6E    6%   �� *
nombrecate+6E   5      �� 5   
   -   5        	 ��Name$	 btn_regresar��5      $��Regresar��6'   $
��Left=�6:   $��162,204,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        
 ��Name$
 txt_restaId��5      $
��Left=�6'   $��23��6B   $��	98,21,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   ��6�   �� *Id+5      5      