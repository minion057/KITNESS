   M S B A M L   `   `   `  ����B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness  5   	       Kitness.Default_ready   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kitness     5   	   J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�6    � WindowState$ 	Maximized=�62    � Title$ KITNESS��5
   	   $	��950��6   $
��1500��6&   .��5      � ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ image/etc/background3.jpg��6(    j� 
AlignmentY$	 Top=�6P    j� 
AlignmentX$ Center=�6a   6w    � RowDefinitions 5   
   �� 5      $��1.25* �6   �� 5      $��8* �6   �� 5      $��2.45* �6   	 � ColumnDefinitions	 5   
   �� 5      $��0.12* �6   �� 5      $��1* �6   �� 5      $��0.12* �6   �� 5      $
��1.5* �6   �� 5      $��0.17* �6   .+�5   
   � $��1��6   $��0��6   	 5      �� 5      $��1* �6#   �� 5      $��7* �6#   .+�5!      �� -   5        $��0��5!      $��0, 35, 0, 10q�6L   ��65   Z� ��5"      �� 5#      .��5%      �� $��image/etc/backbtn.png��6   $
��Fill=�67   5&      5'      � 5*   
   $��0��6   $��3��6   	 5+      �� 5,      $��3* �6#   �� 5-      $��1* �6#   .+�5/      � $��1��6   	 50      �� 51      $��1* �6'   �� 52      $��1* �6'   �� 53      $��1* �6'   .+�55      �� -   5        $��0��55      $��0, 35, 0, 10q�6P   ��69   Z� ��56      �� 57      .��59      �� $"��image/etc/informationbtn.png��6   $
��Fill=�6B   5:      �� 5;      -   5        $��1��5;      $��0, 35, 0, 10q�6Y   ��6B   Z� ��5<      �� 5=      .��5?      �� $��image/etc/tuto3.png��6   $
��Fill=�69   5@      �� 5A      -   5        $��2��5A      $��0, 35, 0, 10q�6P   ��69   Z� ��5B      �� 5C      .��5E      �� $��image/etc/exitbtn.png��6   $
��Fill=�6;   5F      5G      5H       � 5J   
   -   5        
  �Name$
 kinect_test��5J        � Source$ Kinect_View.xaml?�6%   $��1��6?   $��3��6L    K� ZIndex$ 2��6\   �� 5K   
   -   5         ��Name$ kinect_connect��5K      $��image/guide/guide2.png��6(   $��1��6H   $��3��6U   $ 1��6e   �� 5L   
   -   5        $ 
kinect_img��5L      $ ��image/guide/kinect_dis.png��6$   $��1��6H   $��3��6U   $��	0,40,0, 0q�6e   $y�Hidden=�6x   $	��Top=�5M      $ 3��6d   ��6(   ��  �� Path$ ActualWidth� �� ElementName$ kinect_test��6d   �� 5O   
   -   5        $ next_img��5O      $ ��image/guide/guide_next.png��6"   $��1��6F   $��3��6S    J� Opacity$	 0.5Q�6c   $
��0,30q�6q   $y�Hidden=�6   $��Bottom=�5P      $ 4��6g   ��6+   �� $ ActualWidth�$ kinect_test��6g   � 5R   
   $��1��6   $��1��6    5S      �� 5T      $
��1.5* �6    �� 5U      $��1* �6    .+�5W      �� -	   5        $ part_img��5W      $��0��6&   "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��63      AnimatedSource$ image/exercise/leg2_m.gif��6^   �� 5X      -
   5        $ ex_img��5X      $��1��6$   $ ��image/exercise/leg2_ex.png��61   $ 2��6U   $��	0,-55,0,0q�6f   5Y      �� 5[   
   -   5         ��Name$ btStart��5[      $��2��61   $��1��6>   $��30,50,30,70q�6N   $	 0.5Q�6z   ��6c   Z� ��5\      �� 5]      .��5_      �� $��image/etc/startbtn2.jpg��6   $
��Fill=�65   5`      �� 5b   
   -   5        $ 
bt_connect��5b      	reconnect��$��2��6N   $��3��6[   $ 2��6k   $��30,50,30,70q�6�   ��6}   Z� ��5c      �� 5d      .��5f      �� -   5        $ bt_connect_img��5f      $��image/etc/connectbtn.jpg��6,   $
��Fill=�6N   5g      5h      5i      