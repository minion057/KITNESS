   M S B A M L   `   `   `  ���� B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness      Kitness.Tutorial   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  !localclr-namespace:Kitness    � WindowStyle$
  None=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=� � Title$ KITNESS��$	��950��$
��1500��.��� ����  j� Stretch$
 Fill=� �� ImageSource$ image/etc/exit2.jpg�� j� 
AlignmentY$	 Top=� j� 
AlignmentX$ Center=� � RowDefinitions �� $��0.02* ��� $
��0.1* ��� $��1* ��� $��0.05* �.+�� $��1��	 � ColumnDefinitions	 �� $��8* ��� $��1* ��� $
��0.4* �.+�� $��1��	 �� $��1* ��� $��1* �.+��� -   $��0��$��10, 5q���Z� ���� .���� $"��image/etc/informationbtn.png��$
��Fill=��� -   $��1��$��10, 5q���Z� ���� .���� $��image/etc/exitbtn.png��$
��Fill=�� $��2��$��0,20,0,0q�	 �� $��1* ��� $	��10* ��� $��1* �.+��� -   
 ��Name$
 bt_back��$��0��$��20, 350, 0, 350q� J� Opacity$	 0.5Q���Z� ���� .���� $ ��image/tutorial/backbtn.png��$
��Fill=��� -    ��Name$ img_gif��$��1�� K� ZIndex$ 5��$��Center=�$��Uniform=�"  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��   AnimatedSource$" image/tutorial/tutorial1.gif���� -   $
 bt_front��$��2��$��0, 350, 20, 350q���Z� ���� .���� $!��image/tutorial/frontbtn.png��$
��Fill=�