   M S B A M L   `   `   `  ����B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness  5   	       Kitness.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kitness     5   	   J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�6    � WindowState$ 	Maximized=�62    � Title$ KITNESS��5
   	   $	��950��6   $
��1500��6&   .��5      � ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ image/etc/background.jpg��6(    j� 
AlignmentY$	 Top=�6O    j� 
AlignmentX$ Center=�6`   6w    � RowDefinitions 5   
   �� 5      $��2.30* �6   �� 5      $��1.39* �6   .+�5   
   �� -   5        	 ��Name$	 	startbtn1��5      $
��25pt(�6$   $��1��6B   $��0��6O   $��50q�6_   $	��Top=�5      $��Center=�6)   $��1��6F   ��6W   Z� ��5      �� 5      .��5      �� $	��140��6   $��image/etc/startbtn1.jpg��6!   $��Uniform=�6B   5      � 5   
   $��0��6   
 � ColumnDefinitions
 5      �� 5      $��2* �6#   �� 5       $��0.15* �6#   �� 5!      $��0.15* �6#   �� 5"      $
��0.1* �6#   .+�5%      �� -   5         ��Name$ logo_img��5%      $��Bottom=�6&   $��Center=�6A   $��0��6^   $��4��6n   "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��5&         AnimatedSource$ image/etc/logo.gif��6;   $��Uniform=�6q   $��0, 150, 0, 0q�6�   �� 5(      -   5        $	 btinfo��5(      $��Center=�6%   $	��Top=�6B   $��1��6�   $��0, 50q�6�   ��6q   Z� ��5)      �� 5*      .��5,      �� $"��image/etc/informationbtn.png��6   $��Uniform=�6>   $��10q�6P   5-      �� 5.      -   5        $��Center=�5.      $	��Top=�62   $��2��6q   $��0, 50q�6�   ��6Z   Z� ��5/      �� 50      .��52      �� $��image/etc/exitbtn.png��6   $��Uniform=�67   $��10q�6I   53      54      56      57      