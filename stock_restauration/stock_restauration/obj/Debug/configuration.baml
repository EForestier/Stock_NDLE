   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   M Istock_restauration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:stock_restaurationstock_restauration 5   	   &    stock_restauration.configuration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   2local clr-namespace:stock_restauration     5   	     � Title$  Gestion Stock��5	   	   $	��450��6   $	��300��6,    � 
ResizeMode$ CanMinimize=�68    � WindowStartupLocation$ CenterScreen=�6R   ���	#FF1C1C29
���  �� � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $L Fpack://application:,,,/MahApps.Metro;component/Styles/Accents/Red.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � ���	#FF1C1C29.+�5   
   �� -   5         ��Name$ Titre��5      $��Confuguration��6   $
��Left=�67   $��	10,10,0,0q�6R   $	��Top=�6e   $	��185��6}   $��25(�6�   $��Forte)�6�   
���  ��6�   �� 5   
   -   5         ��Name$ btn_valider��5      $��Valider��6&   $��67,371,67,0q�68   $	��Top=�6M   ���	#FF420808
�������$��Segoe UI Light)�6�   $��10(�6�   $��17��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5       � 
 � Color$	
 Red��6#    � Offset$ 0Q�6/   � 5!      $
 	#FFC70000��6#   $ 1Q�65   5"      5$      �� 5&   
   -   5        $ 
lb_adresse��5&      $��
Adresse IP��6$   $
��Left=�69   $��	24,70,0,0q�6T   $	��Top=�6g   $	��185��6   $��15(�6�   $��Forte)�6�   
���  ��6�   �� 5'   
   -   5         ��Name$ BDD_adresse��5'      $
��Left=�6'   $��23��6B   $��
36,105,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��160��6�   �� 5)   
   -   5        $ lb_bdd��5)      $ ��Nom de la base de données��6    $
��Left=�6D   $��
24,143,0,0q�6_   $	��Top=�6s   $	��203��6�   $��15(�6�   $��Forte)�6�   
���  ��6�   �� 5*   
   -   5        $ BDD_nom��5*      $
��Left=�6#   $��23��6>   $��
36,178,0,0q�6J   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��160��6�   �� 5,   
   -   5        $ lb_user��5,      $��Nom d'utilisateur��6!   $
��Left=�6=   $��
24,218,0,0q�6X   $	��Top=�6l   $	��185��6�   $��15(�6�   $��Forte)�6�   
���  ��6�   �� 5-   
   -   5        $ BDD_user��5-      $
��Left=�6$   $��23��6?   $��
36,253,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��160��6�   �� 5/   
   -	   5        $ lb_mdp��5/      $��Mot de passe��6    $
��Left=�67   $��
24,284,0,0q�6R   $	��Top=�6f   $	��185��6~   $��15(�6�   $��Forte)�6�   
���  ��6�   �� 50   
   -
   5        $ BDD_password��50      $
��Left=�6(   $��23��6C   $��
36,319,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��160��6�   51      52      