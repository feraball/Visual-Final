   M S B A M L   `   `   `  ����I  EProyecto Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Proyecto_FinalProyecto_Final  5   	   $    Proyecto_Final.VentanaPlatillo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Proyecto_Final     5   	   -   5          �Name$  frmPlatillo��5   	    � Title$ Agregar Platillo��5   	   $	��340��6"   $	��340��6/    � WindowStartupLocation$ CenterOwner=�6;   
���   � � Icon$ Assets/cata-icon.ico��6r   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ btnRegistrar��5      $��Agregar��6'   $��Center=�69   $��0q�6V   $��Center=�6a   $	��100��6|   $��30��6�   $��4��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��26��6@   $��10,0,0,0q�6L    �� TextWrapping$
 Wrap=�6^   $��Center=�6r   $	��140��6�   $��Center=�6�   ���	#FF4D4D4D
�������$��0q�6�   $��0q�6�   $��14(�6  $
��Bold"�6  $��Center=�6%  $��1��6I  �� 5   
   -   5        	 ��Name$	 	lblNombre��5      $��Nombre:��6#   $��Right=�65   $��0,0,10,0q�6Q   $��Center=�6c   $��30��6~   $	��140��6�   $��Right=�6�   
�������$��14(�6�   $
��Bold"�6�   $��Center=�6�   �� 5   
   -   5        $	 lblTemperatura��5      $��Temperatura:��6(   $��Right=�6?   $��0,0,10,0q�6[   $��Center=�6m   $��30��6�   $	��140��6�   $��Right=�6�   
�������$��14(�6�   $
��Bold"�6�   $��1��6�   $��Center=�6  �� 5   
   -   5        $	 lblCategoria��5      $��Categoría:��6&   $��Right=�6;   $��0,0,10,0q�6W   $��Center=�6i   $��30��6�   $	��140��6�   $��Right=�6�   
�������$��14(�6�   $
��Bold"�6�   $��3��6�   $��Center=�6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $��Center=�69   $��0q�6V   $��Center=�6a   $	��100��6|   $��30��6�   $��1��6�   $��4��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $	 lblTipo��5      $��Tipo:��6!   $��Right=�61   $��0,0,10,0q�6M   $��Center=�6_   $��30��6z   $	��140��6�   $��Right=�6�   
�������$��14(�6�   $
��Bold"�6�   $��2��6�   $��Center=�6�   �� 5   
   -	   5        
 ��Name$
 cbxTemperatura��5      $��1��6+   $
��Left=�6;   $��10,0,0,0q�6V   $��1��6h   $��Center=�6u   $	��136��6�   $��26��6�    �� SelectedIndex$ 0��6�   .@�5      �� $��frío��6   �� 5      $��caliente��6   5      �� 5    
   -
   5        $
 cbxTipo��5       $��1��6$   $
��Left=�64   $��10,0,0,0q�6O   $��2��6a   $��Center=�6n   $	��136��6�   $��26��6�   $ 0��6�   .@�5!      �� $��postre��6   �� 5"      $��plato fuerte��6   �� 5#      $��	aperitivo��6   5$      �� 5%   
   -   5        $
 cbxCategorias��5%      $��1��6*   $
��Left=�6:   $��10,0,0,0q�6U   $��3��6g   $��Center=�6t   $	��136��6�   $��26��6�   $ 0��6�   5&      5'      