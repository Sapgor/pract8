   M S B A M L   `   `   `  ����A  =pract8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SimpleCalculatorSimpleCalculator  5   	   !    SimpleCalculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0localclr-namespace:SimpleCalculator     5   	     � Title$  Simple Calculator��5   	   $	��200��6#   $	��300��60    � DataContext 5      *   $SimpleCalculator.CalculatorViewModel  5   
   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0,0,0,23q�6?   ��6   �� *a+ �� Mode$ TwoWay=�6?   �� 5   
   $��0,23,0,0q�62   ��6   �� *b+$ TwoWay=�62   �� 5   
   $��2��6   $��сложить��6   ��60   �� *
AddCommand+�� 5   
   $��3��6   $��вычесть��6   ��60   �� *minusCommand+�� 5   
   $��0,46,0,0q�6,   $��2��6>   ��6   �� *Result+6>   5      5      