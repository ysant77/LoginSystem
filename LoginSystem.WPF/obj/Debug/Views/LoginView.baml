   M S B A M L   `   `   `  ����J  FLoginSystem.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LoginSystem.WPF.ViewsLoginSystem.WPF.Views  5      %    LoginSystem.WPF.Views.LoginView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:LoginSystem.WPF.Views     5      $��24(�5	        � 	Resources  5
          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      �� $��25q�6    �� Padding$ 50q�6   $��Center=�5   	   $��Center=�5   	   
�������  BrushPrimary2#��[ 5   	   $��3q�5   	    �� CornerRadius$ 10��5   	    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      Color$
 Gray��6/   ._�5   
   �  � IsSharedSizeScope .  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��Center=�5      $��48(�5       $��Login System��5!      �� 5#      $��1��6   $
��0,10q�6%   $��Center=�5$      $��18(�5%      $
��Thin"�5&      $0��*The world's simplest authentication system��5'      � 5)      $��2��6   $
��0,20q�6     5*      �� 5+      $
��auto �6$   �� 5,      $
��auto �6$   �� 5-      $
��auto �6$   �� 5.      $
��auto �6$   .+�51      � $��0��6   $
��0,10q�6$    � ColumnDefinitions 52      �� 53      $
��auto �6+   	 z� SharedSizeGroup$	 Label��68   �� 54      $	��300 �6+   .+�57      �� $��0��6    $��Username��60   �� 58      $��1��6   $��20,0,0,0q�6.   ��59      �� *
Username+
 �� UpdateSourceTrigger$
 PropertyChanged=�5:      � 5<      $��1��6   $
��0,10q�6$    5=      �� 5>      $
��auto �6+   $	 Label��68   �� 5?      $	��300 �6+   .+�5B      �� $��0��6    $��Password��60   G� 5C      -   5         G�Name$ 
pbPassword��5D      $��1��5C   "   $��20,0,0,0q�62    G� Password$ yatharth��5E      5F      �� 5H      -   5        $��2��5H      $
��0,10q�6&   $��Center=�5I      $��Login��5K       �� 	IsDefault . 5L      �� 5N      $��3��6   $��0,10,0,0q�6)   $��Center=�5O      
���  �� � DataContext 5P      �� *ErrorMessageViewModel+��5R      �� *	Message+y�5S      �� *
HasMessage+ �� 	Converter# [  5T      5U      5V      5W      