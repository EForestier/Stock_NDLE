   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   M Istock_restauration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:stock_restaurationstock_restauration 5   	      stock_restauration.Stand   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   2local clr-namespace:stock_restauration     5   	     � Title$  Gestion Stock��5	   	   $	��750��6   $
��1000��6,    � 
ResizeMode$ CanMinimize=�69    � WindowStartupLocation$ CenterScreen=�6R   
���  �����	#FF1C1C29 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $L Fpack://application:,,,/MahApps.Metro;component/Styles/Accents/Red.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � ���	#FF1C1C29.+�5   
   �� -   5         ��Name$ Titre��5      $��Stands��6   $
��Left=�60   $��	36,22,0,0q�6K   $	��Top=�6^   $	��475��6v   $��50(�6�   $��Forte)�6�   
���  �����	#FF1C1C296�   �� 5   
   -   5         ��Name$ 
lbox_titre��5      $��25��6&   $��99,174,95,0q�62   $	��Top=�6G   $	��840��6_    �� SelectedIndex$ 0��6k   ��5      �� 5      .R�5       � $	��0,2q�6   	 � ColumnDefinitions	 5!      �� 5"      $��5 �6/   �� 5#      $	��170 �6/   �� 5$      $��15 �6/   �� 5%      $	��170 �6/   �� 5&      $	��160 �6/   .+�5)      �� $
��Left=�6$   ��6@   �� *rien1+�� 5*      $
��Left=�6$   $��1��6?   ��6O   �� *	article+�� 5+      $
��Left=�6$   $��2��6?   ��6O   �� *rien+�� 5,      $
��left=�6$   $��3��6?   ��6O   �� *stock+�� 5-      $
��left=�6$   $��4��6?   ��6O   �� *sortie+5.      5/      51      �� 53   
   -   5        $ lbox_article��53      $��99,199,95,48q�6(   $	��840��6>   �� 56   
   $��99,174,95,48q�6   
���  ��6*   58      59      