   M S B A M L   `   `   `  ����M  ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=SystemSystem.ComponentModel  5      L HWpfStackerLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfStackerLibraryWpfStackerLibrary 5   �   &    WpfStackerLibrary.StackerControl   5      :cm3clr-namespace:System.ComponentModel;assembly=System  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .myclr-namespace:WpfStackerLibrary     5   �   -   5        $��2q�5   8     � 	Resources  5	      ,   &System.ComponentModel.BackgroundWorker   backgroundWorker!   WorkerSupportsCancellation  CurrCell �� 
TargetType �� Property �� Value  CurrCell_Occupied �� BasedOn  RegCell  RegCell_Occupied  
PoddonCell  PoddonCell_Occupied��%N  &	        &	 ,     &	 �     7  &	     &	 �    7  &	     &	     7    5
   
   -   5         . 5
   �   �� 5   
   " ��6!   .�5      ��  � ��$ 10(�6)   66   �� 5       � ��
 �P��6;   5      �� 5   
   " ��6*   8   .�5      ��  � ��$ 10(�6)   66   �� 5       � ��$
 Bold"�63   6B   5      �� 5   
   " ��6    .�5      ��  � ��$ 10(�6)   66   �� 5       � ��
 �����6?   5      �� 5   
   " ��6)   8   .�5      ��  � ��$ 10(�6)   66   �� 5       � ��$
 Bold"�63   6B   5      �� 5   
   " ��6#   .�5      ��  � ��$ 10(�6)   66   �� 5       � ��
 �����6B   5      �� 5    
   " ��6,   8   .�5!      ��  � ��$ 10(�6)   66   �� 5"       � ��$
 Bold"�63   6B   5#      5$      .��5%      � $��2q�6    � RowDefinitions 5&   
   �� 5'      -   5         �Name$ stacker_left_panel��5'      5)      �� 5*      $��30 �6   5,      �� 5-      -   5        $ stacker_right_panel��5-      5/      .+�51   
   � -   5        $��stacker_rails��51      $��1��6   .+�52      �� -   5        $��stacker_base��52   [   $��2��6   $
��Left=�6)   $��20��6D   $��20��6P   $��2q�6o   
���   � J� OpacityMask
 �   �$��0,0,0,0q�6�   ._�53      ]� -   5        $��stacker_rect��53      $��0,0,0,0q�63     55        stacker_empty  stacker_full�� 56      -   5        StackerStyles��%�   &	       &	 D     �� 57      .�58      ��  � ��
 �����5:      5;      �� 5<      .�5=      ��  � ��
 �����5?      5@      5A      .+�5C      �� -	   5        $��y_rect��5C   B   $��6��6   $��Stretch=�6&   ���	#FF400000$��0,0,0,0q�6b   6u   �� 5D      $��Stretch=�6!   	 �� Orientation$	 Vertical=�6?   .+�5E      �� -
   5        $��z_left_rect��5E   /   $��8��6$   6D   �� 5F      $��0,0,0,0q�6$   ���	#FFFF40006N   �� 5G      $��Stretch=�6$   6B   5H      5J      5K      5L      � 5M   
   -   5        $��	rack_left��5M      $��0��6   $��0q�6-   5O      � 5P   
   -   5        $��
rack_right��5P      $��2��6   $y�Visible=�6.   $��0q�6C   5R      5S      5T      