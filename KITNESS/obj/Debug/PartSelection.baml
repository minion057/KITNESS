   M S B A M L   `   `   `  ����B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness  5   	       Kitness.PartSelection   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   !localclr-namespace:Kitness  5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�6    � WindowState$ 	Maximized=�62    � Title$ KITNESS��5
   	   $	��950��6   $
��1500��6&   .��5      � ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$! image/etc/background2-1.png��6(    j� 
AlignmentY$	 Top=�6R    j� 
AlignmentX$ Center=�6c   6y    � RowDefinitions 5   
   �� 5      $��0.27* �6   �� 5      $
��1.2* �6   �� 5      $��1* �6   �� 5      $��0.15* �6   	 � ColumnDefinitions	 5   
   �� 5      $��0.24* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $��0.24* �6   .+�5"   
   � $��0��6   $��5��6   	 5#      �� 5$      $��2* �6#   �� 5%      $��1* �6#   .+�5'      � $��1��6   	 5(      �� 5)      $��1* �6'   �� 5*      $��1* �6'   �� 5+      $��1* �6'   .+�5-      �� -   5        $��0��5-      $��0, 35, 0, 10q�6P   ��69   Z� ��5.      �� 5/      .��51      �� $"��image/etc/informationbtn.png��6   $
��Fill=�6B   52      �� 53      -   5        $��1��53      $��0, 35, 0, 10q�6Y   ��6B   Z� ��54      �� 55      .��57      �� $��image/etc/tuto3.png��6   $
��Fill=�69   58      �� 59      -   5        $��2��59      $��0, 35, 0, 10q�6P   ��69   Z� ��5:      �� 5;      .��5=      �� $��image/etc/exitbtn.png��6   $
��Fill=�6;   5>      5?      5@      � 5C   
   $��2��6   $��1��6    5D      �� 5E      $��1* �6    �� 5F      $��1* �6    �� 5G      $��1* �6    .+�5I      �� -   5        
 ��Name$
 neck1��5I      어깨 올리기��$��0��6�   $��17q�6�   ��6�   Z� ��5J      �� 5K      .��5M      �� $"��image/exercise/neck1_btn.png��6   $
��Fill=�6>   5N      �� 5O      -   5        $
 neck2��5O      "머리 기울여 목 늘리기��$��1��6�   $��17q�6�   ��6�   Z� ��5P      �� 5Q      .��5S      �� $"��image/exercise/neck2_btn.png��6   $
��Fill=�6>   5T      �� 5U      -   5        $
 neck3��5U      통닭 자세��$��2��6�   $��17q�6�   ��6�   Z� ��5V      �� 5W      .��5Y      �� $"��image/exercise/neck3_btn.png��6   $
��Fill=�6>   5Z      5[      � 5^   
   $��2��6   $��3��6    5_      �� 5`      $��1* �6    �� 5a      $��1* �6    �� 5b      $��1* �6    .+�5d      �� -   5        $
 spine1��5d      한쪽 다리 뻗기��$��0��6�   $��17q�6�   ��6�   Z� ��5e      �� 5f      .��5h      �� $#��image/exercise/spine1_btn.png��6   $
��Fill=�6?   5i      �� 5j      -   5        $
 spine2��5j      옆구리 늘이기��$��1��6�   $��17q�6�   ��6�   Z� ��5k      �� 5l      .��5n      �� $#��image/exercise/spine2_btn.png��6   $
��Fill=�6?   5o      �� 5p      -	   5        $
 spine3��5p      전신 늘이기��$��2��6�   $��17q�6�   ��6�   Z� ��5q      �� 5r      .��5t      �� $#��image/exercise/spine3_btn.png��6   $
��Fill=�6?   5u      5v      � 5y   
   $��2��6   $��5��6    5z      �� 5{      $��1* �6    �� 5|      $��1* �6    �� 5}      $��1* �6    .+�5      �� -
   5        $

 leg1��5      ,(한쪽 다리 옆으로 들어 올리기��$��0��6�   $��17q�6�   ��6�   Z� ��5�      �� 5�      .��5�      �� $!��image/exercise/leg1_btn.png��6   $
��Fill=�6=   5�      �� 5�      -   5        $

 leg2��5�      ($한쪽 무릎 옆으로 구부리기��$��1��6�   $��17q�6�   ��6�   Z� ��5�      �� 5�      .��5�      �� $!��image/exercise/leg2_btn.png��6   $
��Fill=�6=   5�      �� 5�      -   5        $

 leg3��5�      ,(무릎 벌려 엉덩이 내리고 앉기��$��2��6�   $��17q�6�   ��6�   Z� ��5�      �� 5�      .��5�      �� $!��image/exercise/leg3_btn.png��6   $
��Fill=�6=   5�      5�      �� 5�   
   -   5         ��Name$ img_gif��5�      $��1��6!   $��1��61   $��5��6>    K� ZIndex$ 5��6R   $��Center=�6c   $��Uniform=�6�   $y�Hidden=�6�   "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��5�         AnimatedSource$ image/exercise/neck1.gif��6;   5�      5�      