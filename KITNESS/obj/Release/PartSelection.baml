   M S B A M L   `   `   `  ���� B  >Kitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KitnessKitness      Kitness.PartSelection   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  !localclr-namespace:Kitness    � WindowStyle$
  None=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=� � Title$ KITNESS��$	��950��$
��1500��.��� ����  j� Stretch$
 Fill=� �� ImageSource$! image/etc/background2-1.png�� j� 
AlignmentY$	 Top=� j� 
AlignmentX$ Center=� � RowDefinitions �� $��0.27* ��� $
��1.2* ��� $��1* ��� $��0.15* �	 � ColumnDefinitions	 �� $��0.24* ��� $��1* ��� $
��0.1* ��� $��1* ��� $
��0.1* ��� $��1* ��� $��0.24* �.+�� $��0��$��5��	 �� $��2* ��� $��1* �.+�� $��1��	 �� $��1* ��� $��1* ��� $��1* �.+��� -   $��0��$��0, 35, 0, 10q���Z� ���� .���� $"��image/etc/informationbtn.png��$
��Fill=��� -   $��1��$��0, 35, 0, 10q���Z� ���� .���� $��image/etc/tuto3.png��$
��Fill=��� -   $��2��$��0, 35, 0, 10q���Z� ���� .���� $��image/etc/exitbtn.png��$
��Fill=�� $��2��$��1�� �� $��1* ��� $��1* ��� $��1* �.+��� -   
 ��Name$
 neck1��어깨 올리기��$��0��$��17q���Z� ���� .���� $"��image/exercise/neck1_btn.png��$
��Fill=��� -   $
 neck2��"머리 기울여 목 늘리기��$��1��$��17q���Z� ���� .���� $"��image/exercise/neck2_btn.png��$
��Fill=��� -   $
 neck3��통닭 자세��$��2��$��17q���Z� ���� .���� $"��image/exercise/neck3_btn.png��$
��Fill=�� $��2��$��3�� �� $��1* ��� $��1* ��� $��1* �.+��� -   $
 spine1��한쪽 다리 뻗기��$��0��$��17q���Z� ���� .���� $#��image/exercise/spine1_btn.png��$
��Fill=��� -   $
 spine2��옆구리 늘이기��$��1��$��17q���Z� ���� .���� $#��image/exercise/spine2_btn.png��$
��Fill=��� -	   $
 spine3��전신 늘이기��$��2��$��17q���Z� ���� .���� $#��image/exercise/spine3_btn.png��$
��Fill=�� $��2��$��5�� �� $��1* ��� $��1* ��� $��1* �.+��� -
   $

 leg1��,(한쪽 다리 옆으로 들어 올리기��$��0��$��17q���Z� ���� .���� $!��image/exercise/leg1_btn.png��$
��Fill=��� -   $

 leg2��($한쪽 무릎 옆으로 구부리기��$��1��$��17q���Z� ���� .���� $!��image/exercise/leg2_btn.png��$
��Fill=��� -   $

 leg3��,(무릎 벌려 엉덩이 내리고 앉기��$��2��$��17q���Z� ���� .���� $!��image/exercise/leg3_btn.png��$
��Fill=��� -    ��Name$ img_gif��$��1��$��1��$��5�� K� ZIndex$ 5��$��Center=�$��Uniform=�$y�Hidden=�"  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��   AnimatedSource$ image/exercise/neck1.gif��