   M S B A M L   `   `   `  ����  
MainWindow    TuProyecto.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Tu Proyecto��5   	   $	��450��6   $	��800��6*   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Nombre:��6   $��Center=�6'   �� 5      -   5         ��Name$ 	txtNombre��5      $��5q�6)   �� 5      $��Edad:��6   $��Center=�6%   $��10,0,0,0q�6@   �� 5      -   5        $ txtEdad��5      $��5q�6'   �� 5      -   5        $��Insertar��5      $��10,0,0,0q�6B   �� 5      -   5        $��
Actualizar��5      $��10,0,0,0q�6F   �� 5      -   5        $��Eliminar��5      $��10,0,0,0q�6B   5      �� 5   
   -   5        $��1��5      $��Cargar Datos��6   $��10q�6M   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5       $��2��6   $��10q�62      AutoGenerateColumns$
 True��6>   5      5      