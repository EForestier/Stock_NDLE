   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   M Istock_restauration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:stock_restaurationstock_restauration 5   	   (   "stock_restauration.nouveau_article   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   2local clr-namespace:stock_restauration     5   	     � Title$  Gestion Stock��5	   	   $	��750��6    $
��1000��6-    � 
ResizeMode$ CanMinimize=�6:    � WindowStartupLocation$ CenterScreen=�6S   
���  �����	#FF1C1C29 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $L Fpack://application:,,,/MahApps.Metro;component/Styles/Accents/Red.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      (   "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        $��heure��5      $��00:00:00��6!   66   5      .��5      � ���	#FF1C1C29.+�5!   
   �� -   5         ��Name$ Titre��5!      $��Nouvel article��6   $
��Left=�68   $��	52,25,0,0q�6S   $	��Top=�6f   $	��326��6~   $��50(�6�   $��Forte)�6�   
���  ��$��67��6�   �� 5%   
   -   5        $ 
lb_article��5%      $��Article��6$   $
��Left=�66   $��
10,139,0,0q�6Q   $	��Top=�6e   $	��108��6}   $��30(�6�   $��Forte)�6�   
���  ��$��43��6�   �� 5&   
   -   5         ��Name$ tBox_article��5&      $
��Left=�6)   $��27��6D   $��178,155,0,0q�6P   	 �� TextWrapping$
	 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��315��6�   �� 5(   
   -   5        $ lb_quantite��5(      $��Quantite��6%   $
��Left=�68   $��
10,203,0,0q�6S   $	��Top=�6g   $	��146��6   $��30(�6�   $��Forte)�6�   
���  ��$��56��6�   �� 5)   
   -   5        $ tBox_quantite��5)      $
��Left=�6)   $��23��6D   $��178,221,0,0q�6P   $
	 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��315��6�   �� 5-   
   -   5        $ lb_stand��5-      $��Stand��6"   $
��Left=�62   $��
10,271,0,0q�6M   $	��Top=�6a   $	��108��6y   $��30(�6�   $��Forte)�6�   
���  ��$��43��6�   �� 5.   
   -   5        
 ��Name$
 cb_barbeuck��5.      $��Barbeuck��6)   $
��Left=�6<   $��
52,337,0,0q�6W   $	��Top=�6k   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 5/   
   -	   5        $
 cb_crepe��5/      $��Crêpe - Galette��6%   $
��Left=�6?   $��
52,369,0,0q�6Z   $	��Top=�6n   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 50   
   -
   5        $
 	cb_gateau��50      $��Confiserie - Café��6&   $
��Left=�6B   $��
52,401,0,0q�6]   $	��Top=�6q   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 51   
   -   5        $
 	cb_chiken��51      $��Chiken Regal��6&   $
��Left=�6=   $��260,337,0,0q�6X   $	��Top=�6m   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 52   
   -   5        $
 cb_consomable��52      $��	Economats��6*   $
��Left=�6>   $��432,337,0,0q�6Y   $	��Top=�6n   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 53   
   -   5        $
 cb_pate��53      $��Pâte��6$   $
��Left=�63   $��260,416,0,0q�6N   $	��Top=�6c   $��20(�6{   $��Forte)�6�   
���  ��6�   �� 54   
   -   5        $
 cb_vin��54      $��Vin - Formage��6#   $
��Left=�6;   $��260,376,0,0q�6V   $	��Top=�6k   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 56   
   -   5        $
 cb_erdre��56      $��Erdre��6%   $
��Left=�65   $��682,337,0,0q�6P   $	��Top=�6e   $��20(�6}   $��Forte)�6�   
���  ��6�   �� 57   
   -   5        $
 
cb_chateau��57      $��Chateau��6'   $
��Left=�69   $��682,376,0,0q�6T   $	��Top=�6i   $��20(�6�   $��Forte)�6�   
���  ��6�   �� 5:   
   -   5         ��Name$ btn_nouveau��5:      $��Ajouter��6&   $
��Left=�68   $��710,240,0,0q�6S   $	��Top=�6h   $	��242��6�   $��20(�6�   $��46��6�   $��Segoe UI Light)�6�   
����������	#FF420808��5;      �� 5<       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5=      �  � Color$	 Red��6#    � Offset$ 0Q�6/   � 5>      $ 	#FFC70000��6#   $ 1Q�65   5?      5A      �� 5H   
   -   5         ��Name$ footer��5H      $
��Left=�6    $	��248��6;   $��-24,473,-550,0q�6H   $	��Top=�6`   $
��1568��6x   $��
footer.png��6�   5Q      5R      