   M S B A M L   `   `   `  ����B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness  5   	       Kitness.Tutorial   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   !localclr-namespace:Kitness  5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�6    � WindowState$ 	Maximized=�62    � Title$ KITNESS��5
   	   $	��950��6   $
��1500��6&   .��5      � ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ image/etc/exit2.jpg��6(    j� 
AlignmentY$	 Top=�6J    j� 
AlignmentX$ Center=�6[   6q    � RowDefinitions 5   
   �� 5      $��0.02* �6   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $��0.05* �6   .+�5   
   � $��1��6   	 � ColumnDefinitions	 5      �� 5      $��8* �6#   �� 5      $��1* �6#   �� 5      $
��0.4* �6#   .+�5      � $��1��6   	 5      �� 5      $��1* �6'   �� 5       $��1* �6'   .+�5"      �� -   5        $��0��5"      $��10, 5q�6P   ��69   Z� ��5#      �� 5$      .��5&      �� $"��image/etc/informationbtn.png��6   $
��Fill=�6B   5'      �� 5(      -   5        $��1��5(      $��10, 5q�6P   ��69   Z� ��5)      �� 5*      .��5,      �� $��image/etc/exitbtn.png��6   $
��Fill=�6;   5-      5.      5/      � 51   
   $��2��6   $��0,20,0,0q�6   	 52      �� 53      $��1* �6#   �� 54      $	��10* �6#   �� 55      $��1* �6#   .+�57      �� -   5        
 ��Name$
 bt_back��57      $��0��6&   $��20, 350, 0, 350q�6\    J� Opacity$	 0.5Q�6u   ��6E   Z� ��58      �� 59      .��5;      �� $ ��image/tutorial/backbtn.png��6   $
��Fill=�6<   5<      �� 5=      -   5         ��Name$ img_gif��5=      $��1��6%    K� ZIndex$ 5��65   $��Center=�6F   $��Uniform=�6c   "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��5>         AnimatedSource$" image/tutorial/tutorial1.gif��6;   �� 5?      -   5        $
 bt_front��5?      $��2��6'   $��0, 350, 20, 350q�6^   ��6G   Z� ��5@      �� 5A      .��5C      �� $!��image/tutorial/frontbtn.png��6   $
��Fill=�6=   5D      5E      5F      5G      