   M S B A M L   `   `   `  ���� B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness      Kitness.Default_ready   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Kitness     J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com    � WindowStyle$
  None=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=� � Title$ KITNESS��$	��950��$
��1500��.��� ����  j� Stretch$
 Fill=� �� ImageSource$ image/etc/background3.jpg�� j� 
AlignmentY$	 Top=� j� 
AlignmentX$ Center=� � RowDefinitions �� $��1.25* ��� $��8* ��� $��2.45* �	 � ColumnDefinitions	 �� $��0.12* ��� $��1* ��� $��0.12* ��� $
��1.5* ��� $��0.17* �.+�� $��1��$��0��	 �� $��1* ��� $��7* �.+��� -   $��0��$��0, 35, 0, 10q���Z� ���� .���� $��image/etc/backbtn.png��$
��Fill=�� $��0��$��3��	 �� $��3* ��� $��1* �.+�� $��1��	 �� $��1* ��� $��1* ��� $��1* �.+��� -   $��0��$��0, 35, 0, 10q���Z� ���� .���� $"��image/etc/informationbtn.png��$
��Fill=��� -   $��1��$��0, 35, 0, 10q���Z� ���� .���� $��image/etc/tuto3.png��$
��Fill=��� -   $��2��$��0, 35, 0, 10q���Z� ���� .���� $��image/etc/exitbtn.png��$
��Fill=� � -   
  �Name$
 kinect_test��  � Source$ Kinect_View.xaml?�$��1��$��3�� K� ZIndex$ 2���� -    ��Name$ kinect_connect��$��image/guide/guide2.png��$��1��$��3��$ 1���� -   $ 
kinect_img��$ ��image/guide/kinect_dis.png��$��1��$��3��$��	0,40,0, 0q�$y�Hidden=�$	��Top=�$ 3������  �� Path$ ActualWidth� �� ElementName$ kinect_test���� -   $ next_img��$ ��image/guide/guide_next.png��$��1��$��3�� J� Opacity$	 0.5Q�$
��0,30q�$y�Hidden=�$��Bottom=�$ 4������ $ ActualWidth�$ kinect_test��� $��1��$��1�� �� $
��1.5* ��� $��1* �.+��� -	   $ part_img��$��0��"  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��   AnimatedSource$ image/exercise/leg2_m.gif���� -
   $ ex_img��$��1��$ ��image/exercise/leg2_ex.png��$ 2��$��	0,-55,0,0q��� -    ��Name$ btStart��$��2��$��1��$��30,50,30,70q�$	 0.5Q���Z� ���� .���� $��image/etc/startbtn2.jpg��$
��Fill=��� -   $ 
bt_connect��	reconnect��$��2��$��3��$ 2��$��30,50,30,70q���Z� ���� .���� -   $ bt_connect_img��$��image/etc/connectbtn.jpg��$
��Fill=�