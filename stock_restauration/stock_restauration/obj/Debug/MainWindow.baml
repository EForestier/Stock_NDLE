   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   M Istock_restauration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:stock_restaurationstock_restauration 5   	   #   stock_restauration.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   2local clr-namespace:stock_restauration     5   	     � Title$  Gestion Stock��5	   	   $	��750��6   $
��1000��6,    � 
ResizeMode$ CanMinimize=�69    � WindowStartupLocation$ CenterScreen=�6R   
���  �����	#FF1C1C29 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $L Fpack://application:,,,/MahApps.Metro;component/Styles/Accents/Red.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      (   "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        $��heure��5      $��00:00:00��6!   66   �� 5      -   5        $��Programmation��5      6.   �� 5      -   5        $��Configuration��5      6.   5      .��5!      � ���	#FF1C1C29.+�5#   
   �� -   5         ��Name$ btn_benevole��5#      $��Benevole��6'   $
��Left=�6:   $��110,346,0,0q�6U   $	��Top=�6j   $	��316��6�   $��40(�6�   $��71��6�   ���	#FF420808
�������$��Segoe UI Light)�6�   ��5$      �� 5%       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5&      � 
 � Color$	
 Red��6#    � Offset$ 0Q�6/   � 5'      $
 	#FFC70000��6#   $ 1Q�65   5(      5*      �� 5+   
   -   5        $ btn_organisateur��5+      $��Organisteur��6+   $
��Left=�6A   $��554,346,0,0q�6\   $	��Top=�6q   $	��330��6�   $��40(�6�   $��71��6�   $��Segoe UI Light)�6�   
����������	#FF420808��5,      �� 5-      $ 0.5,1&�6&   $	 0.5,0&�67   .��5.      � $	
 Red��6#   $ 0Q�6/   � 5/      $
 	#FFC70000��6#   $ 1Q�65   50      52      �� 55   
   -   5         ��Name$ footer��55      $
��Left=�6    $	��248��6;   $��-28,473,-546,0q�6H   $	��Top=�6`   $
��1568��6x   $��
footer.png��6�   �� 56   
   -   5        $
 logo��56      $
��Left=�6   $	��166��69   $��-323,93,-310,0q�6F   $	��Top=�6^   $
��1627��6v   $��logoville.png��6�   58      5:      