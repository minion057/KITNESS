   M S B A M L   `   `   `  ���� B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness      Kitness.Default_start   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Kitness       � WindowStyle$
  None=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=� � Title$ KITNESS��$	��950��$
��1500��.��� ����  j� Stretch$
 Fill=� �� ImageSource$ image/etc/background.jpg�� j� 
AlignmentY$	 Top=� j� 
AlignmentX$ Center=� � ColumnDefinitions �� $
��3.5* ��� $��1* �.+��� -   	 ��Name$	 	guide_img��$ ��image/guide/kinect_dis.png��$��0��$��0��$��	0,70,0, 0q�$	��Top=�
 K� ZIndex$
 3�� � -     �Name$ kinect_test��  � Source$ Kinect_View.xaml?�$��0��$��0��$��2��$
 2���� $��image/guide/guide2.png��$��0��$��0��$
 1��$��300, 100, 100, 100q�� $��0��$��0��$��50q�$
 2�� � RowDefinitions �� $
��0.7* ��� $��1* � �� $��1* ��� $��1* �.+��� -   $	 part_img��$y�Hidden=�$��image/exercise/ready.png��$��20q�$��0��$��0��$��2��$
��Fill=��� -   $	 	cheer_img��$*��$image/exercise_etc/exercise_good.png��$��10, 50, 200, 10q�$
 3��$��0��$��1��$y�Hidden=�� $��1��$��10, 0, 50, 5q� �� $
��0.5* ��� $
��0.3* ��� $
��0.5* ��� $
��0.6* ��� $
��0.5* ��� $
��0.6* ��� $
��0.3* ��� $
��0.3* �.+�� $��0�� �� $
��0.5* ��� $��1* �.+�� $��1�� �� $��1* ��� $��1* ��� $��1* �.+��� -   $��0��$��0, 65, 0, 10q���Z� ���� .���� $��image/etc/backbtn.png��$
��Fill=��� -   $��1��$��0, 65, 0, 10q���Z� ���� .���� $��image/etc/tuto3.png��$
��Fill=��� -   $��2��$��0, 65, 0, 10q���Z� ���� .���� $��image/etc/exitbtn.png��$
��Fill=��� -   $	 	part_name��$!��image/exercise/leg1_btn.png��$��Uniform=�$��1��$��Center=�$	��7,0q��� $ ��image/exercise_etc/set.png��$��Uniform=�$��2��$��Center=��� -	    ��Name$ setcount��$��1��$
��80pt(�$��3��$��Center=�$��Center=��� $��image/etc/cnt_img.png��$��Uniform=�$��4��$��Center=�$	��7,0q��� -
   $ count��$��1��$
��80pt(�$��5��$��Center=�$��Center=��� -    ��Name$ 
bt_connect��	reconnect��$��6��$��7,10, 7, 20q���Z� .���� -   $	 bt_connect_img��$��image/etc/connectbtn2.jpg��$
��Fill=��� -   $ 
bt_restart��$��7��$��7,10, 7, 20q���Z� .���� $��image/etc/restart.jpg��$
��Fill=�