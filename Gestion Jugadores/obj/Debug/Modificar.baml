   M S B A M L   `   `   `  ����L  HGestion Jugadores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Gestion_JugadoresGestion_Jugadores  5   	   !    Gestion_Jugadores.Modificar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Gestion_Jugadores     5   	     � Title$  Window1��5	   	   $��675.333��6   $��628.333��6*   .��5
      � $��10,29,3.333,6q�6   .+�5   
   �� $��Nombre��6   $
��Left=�6!   $��110,115,0,0q�6<   $	��Top=�6Q   �� 5   
   $��Apellido��6   $
��Left=�6#   $��110,180,0,0q�6>   $	��Top=�6S   �� 5   
   $��Equipo��6   $
��Left=�6!   $��110,245,0,0q�6<   $	��Top=�6Q   �� 5   
   $��Posicion��6   $
��Left=�6#   $��110,309,0,0q�6>   $	��Top=�6S   �� 5   
   $��Fecha
��6   $
��Left=�6*   $��110,360,0,0q�6E   $	��Top=�6Z   �� 5   
   -   5         ��Name$
 tbID��5      $
��Left=�6    $��23��6;   $��
255,33,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   -   5        $ tbNombre��5      $
��Left=�6$   $��23��6?   $��270,115,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ 
tbApellido��5      $
��Left=�6&   $��23��6A   $��270,192,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ tbEquipo��5      $
��Left=�6$   $��23��6?   $��270,257,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ 
tbPosicion��5      $
��Left=�6&   $��23��6A   $��270,313,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dpCalendar��5      $
��Left=�6)   $��270,361,0,0q�6D   $	��Top=�6Y   �� 5   
   -   5         ��Name$ 
btCancelar��5      $��Cancelar��6%   $
��Left=�68   $��340,554,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ 	btAceptar��5      $��Aceptar��6$   $
��Left=�66   $��475,555,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   $��Salario��6   $
��Left=�6"   $��113,419,0,0q�6=   $	��Top=�6R   �� 5   
   -	   5        $ 	tbSalario��5      $
��Left=�6%   $��23��6@   $��270,419,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $��Altura��6   $
��Left=�6!   $��113,464,0,0q�6<   $	��Top=�6Q   �� 5   
   -
   5        $ tbAltura��5      $
��Left=�6$   $��23��6?   $��270,468,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�    J� RenderTransformOrigin$ -0.333,0.913&�6�   �� 5   
   $��Introduzca una id��6   $
��Left=�6,   $��
82,0,0,555q�6G   $��26��6[   $��Bottom=�6g   �� 5   
   -   5        $ btBuscar��5      $��Buscar��6#   $
��Left=�64   $��
475,33,0,0q�6O   $	��Top=�6c   $��75��6{   6�   5      5       