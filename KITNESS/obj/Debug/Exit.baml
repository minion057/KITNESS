   M S B A M L   `   `   `  ����B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness  5   	       Kitness.Exit   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kitness     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowState$ 	Maximized=�62    � Title$ KITNESS��5	   	   $	��950��6   $
��1500��6&   .��5
      � ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ image/etc/background.jpg��6(    j� 
AlignmentY$	 Top=�6O    j� 
AlignmentX$ Center=�6`   6v    � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5      $��2* �6   �� 5      $
��0.5* �6   �� 5      $
��0.3* �6   �� 5      $
��0.2* �6   .+�5   
   �� $��1��6   $��Center=�6   $��Center=�6:   $��image/etc/goodbye.png��6U   �� 5   
   -   5        	 ��Name$	 user_img��5      $(��"image/exercise_etc/exercise_no.png��6"   $��2��6N   $��300, 30q�6[   $��Uniform=�6l   
 K� ZIndex$
 3��6~   �� 5   
   -   5         ��Name$ file_src��5      $+��%사진 운동명 ( 운동한 날짜 )��6"   $��3��6>   $��Center=�6K   $
��30pt(�6h   $��Center=�6x   �� 5   
   -   5        $
��Left=�5      $��4��6:   $��70, 3q�6^   ��6G   Z� .��5      �� $��image/etc/closebtn3.jpg��6   $��Uniform=�65   5      �� 5   
   -   5        $��4��5      $��Right=�6+   $��70, 3q�6^   ��6G   Z� .��5      �� $��image/etc/backbtn2.jpg��6   $��Uniform=�64   5      5      5       