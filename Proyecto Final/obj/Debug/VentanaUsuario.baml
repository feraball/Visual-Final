   M S B A M L   `   `   `  ����  Proyecto Final#    Proyecto_Final.VentanaUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$  frmVentanaUsuario��5   	    � Title$ Bienvenido Usuario��5      $��464.5��6    $	��600��6/    � Icon$ Assets/cata-icon.ico��6;    � WindowStartupLocation$ CenterScreen=�6W   .��5      �  � RowDefinitions 5   
   �� 5      $��22 �6   �� 5      �� 5	      �� 5
      �� 5      �� 5      $
��0.6* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $
��169* �6   �� 5      $
��168* �6   �� 5      $
��220* �6   .+�5   
   o� $��3��6   $��0,0,-0.443,0q�6#   .@�5      m� -   5         m�Name$ menu_MenuArchivo��5      $��Archivo��61   .@�5      m� -   5        $ menu_NewPlatillo��5      $��Nuevo Platillo��65   {�.  6M   m� 5      -   5        $ menu_importarXml��5      $��Importar/Exportar XML��65   $
��Left=�6T   $	��228��6o   {�.  6{   m� 5      -   5        $ menu_cargarBd��5      $��Cargar/Guardar BD��62   {�.  6M   m� 5      -   5        $ menu_cerrarSesion��5      $��Cerrar Sesión��66   m� 5      -   5        $ 
menu_Salir��5      $��Salir del Sistema...��6/   5      m� 5      -   5        $ menu_MenuEditar��5      $��Herramientas��60   .@�5      m� -	   5        $ menu_buscarPlatillo��5      $��Buscar Platillo��68   {�.  6Q   m� 5      -
   5        $ menu_Listar��5      $��	Listar...��60   .@�5      m� -   5        $ menu_listarPlatillos��5      $��Listar Platillos��6=   {�.  6W   m� 5       -   5        $ menu_listarCategorias��5       $%��Listar Platillos por Categoría��6>   {�.  6f   m� 5!      -   5        $ menu_listarRestaurantes��5!      $��Listar Restaurantes��6@   {�.  6]   5"      m� 5#      -   5        $ menu_editarPlatillo��5#      $��Editar Platillo��68   {�.  6Q   5$      m� 5%      -   5        $ mitMenuAyuda��5%      $��Ayuda��6-   .@�5&      m� -   5        $ mitAcercaDe��5&      $��Acerca de...��60   5'      5(      �� 5)   
   -   5         ��Name$ lblTU��5)      $��Tipo de Usuario:��6   $��Right=�6:   $��0,0,10,0q�6V   $��1��6h   $��Center=�6u   $��26��6�   $��96��6�   $��Right=�6�   $��Center=�6�   �� 5*   
   -   5        $ 	lblNombre��5*      $��Nombre:��6#   $��Right=�65   $��0,0,10,0q�6Q   $��2��6c   $��Center=�6p   $��26��6�   $��96��6�   $��Right=�6�   $��Center=�6�   �� 5+   
   -   5        $ lblRestaurante��5+      $��Restaurante:��6(   $��Right=�6?   $��0,0,10,0q�6[   $��3��6m   $��Center=�6z   $��26��6�   $��96��6�   $��Center=�6�   $��Right=�6�   �� 5,   
   -   5         ��Name$ cbxCategorias��5,      $
��Left=�6*   $��10,0,0,0q�6E   $��4��6W   $��Center=�6d   $	��140��6   $��26��6�   $��Center=�6�   $��Center=�6�   {�.  $��1��6�   �� 5-   
   -   5        	 ��Name$	 	txtBuscar��5-      $��2��6%   $��Center=�65   $��26��6R   $��0q�6^   $��4��6i   
 �� TextWrapping$

 Wrap=�6v   $��Buscar Platillo��6�   $��Center=�6�   $	��150��6�   $��Center=�6�   $��5,0,0,0q�6�   {�.  6�   �� 5.   
   -   5         ��Name$ imgFotoUsuario��5.      $��2��6(   $��Center=�68   $	��120��6U   $��56.443,17,56.557,17q�6b   $��3��6   $��Center=�6�   $	��120��6�    J� RenderTransformOrigin$ 	0.49,0.51&�6�   $��1��6�   $��Assets/users.png��6�   &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ dtgGrillaDatos��5/      $��10q�6+   $��6��67   $��3��6D      CanUserAddRows .     
IsReadOnly . {�.     AutoGenerateColumns .  $y�Hidden=�6�   ��6X   ��  �� Path$ 	platillos�   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Titulo��6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Titulo+   ClipboardContentBinding 6@   Z� 6c     52      $ 
Categoría��6f    6%   �� *	Categoria+ 6C   Z� 6f     53      $
 Tipo��6a    6%   �� *Tipo+ 6>   Z� 6a   55      �� 56   
   -   5        $ lblTipoUsuario��56      $��1��6(   $
��Left=�68   $��10,0,0,0q�6S   $��1��6e   $��Center=�6r   $��26��6�   $	��140��6�   $��0q�6�   ���	#FFCBFFCD6�   �� 57   
   -   5        $ lblNombreUsuario��57      $��1��6*   $
��Left=�6:   $��10,0,0,0q�6U   $��2��6g   $��Center=�6t   $��26��6�   $	��140��6�   $��0q�6�   ���	#FFCBFFCD6�   �� 58   
   -   5        $ lblRestauranteUsuario��58      $�� ��6/   $��1��6:   $
��Left=�6J   $��10,0,0,0q�6e   $��3��6w   $��Center=�6�   $��26��6�   $	��140��6�   $��0q�6�   ���	#FFCBFFCD6�     59   
   -   5        $ dtgRestaurantes��59      $��10q�6,   $��6��68    .     EnableRowVirtualization .  $��3��6�   $y�Hidden=�6�   ��6a   �� $ restaurantes� 5:        5;      $ Nombre��6A    6%   �� *nombre+6A     5<      $ 	Direccion��6D    6%   �� *	direccion+6D     5=      $ Telefono��6C    6%   �� *
telefono+6C     5>      $ Dueno��6A    6%   �� *duenio+6A     5?      $ 	Asistente��6E    6%   �� *
nombreasis+6E   5A      �� 5B   
   -   5        $ lbl_listaResta��5B      $��Lista de Restaurantes��6(   $��0q�6H   $��5��6S   $��Center=�6`   $��Center=�6}   $	��400��6�   $��26��6�   $��3��6�   $��Center=�6�   $��Center=�6�   $y�Hidden=�6
  �� 5C   
   -   5        $ 	lbl_newBD��5C      $
��Cero��6#   $
��Left=�62   $��34,0,0,0q�6M   $��1��6_   $	��Top=�6l   $��50��6�   $	��517��6�   $��3��6�   �� 5D   
   -   5        $ imgCatalogoDelicias��5D      $
��Left=�6-   $	��192��6H   $��	20,15,0,0q�6U   $��4��6h   $	��Top=�6u   $	��551��6�   $��3��6�   $!��Assets/catalogoDelicias.png��6�   $
��Fill=�6�   $��3��6�   $y�	Collapsed=�6�   �� 5E   
   -   5        $ lblCategoria��5E      $��Escoger Categoría:��6&   $��Right=�6C   $��0,0,10,0q�6_   $��4��6q   $��Center=�6~   $��26��6�   $	��116��6�   $��Center=�6�   $��Right=�6�   5G      5H      