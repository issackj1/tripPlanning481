   M S B A M L   `   `   `  ����Q  MExploreYYCHighFidelity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ExploreYYCHighFidelityExploreYYCHighFidelity  5      )    #ExploreYYCHighFidelity.Welcome_Page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ExploreYYCHighFidelity     5        � 	Resources  5	         Opening �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime&   System.Windows.VerticalAlignment   Center R� Value<  6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime	 p� Value8  2System.Windows.Media.Animation.EasingColorKeyFrame
 �� KeyTime �� Value  System.Windows.Visibility   Hidden   Visible��%�  &	        �� 5
   
   .��5      U� $ (UIElement.Opacity)�6,   $ logInButton��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.8��6'   $ 0Q�69     5      $ 0:0:1.5��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ userBox��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.8��6'   $ 0Q�69     5      $ 0:0:1.5��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ passBox��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.8��6'   $ 0Q�69     5      $ 0:0:1.5��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ 	userBlock��6\   .\�5        $ 0��6'   $	 0.6Q�63     5      $ 0:0:0.8��6'   $ 0Q�69     5      $ 0:0:1.5��6'   $ 0.595Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ 	passBlock��6\   .\�5         $ 0��6'   $	 0.6Q�63     5!      $ 0:0:0.8��6'   $ 0Q�69     5"      $ 0:0:1.5��6'   $	 0.6Q�69   5#      U� 5$      $ (UIElement.Opacity)�6,   $ signUpButton��6\   .\�5%        $ 0��6'   $ 1Q�63     5&      $ 0:0:0.8��6'   $ 0Q�69     5'      $ 0:0:1.5��6'   $ 1Q�69   5(      U� 5)      $ (UIElement.Opacity)�6,   $ forgotButton��6\   .\�5*        $ 0��6'   $ 1Q�63     5+      $ 0:0:0.8��6'   $ 0Q�69     5,      $ 0:0:1.5��6'   $ 1Q�69   5-      U� 5.      $ (UIElement.Opacity)�6,   $ forgotBlock��6\   .\�5/        $ 0��6'   $ 1Q�63     50      $ 0:0:0.8��6'   $ 0Q�69     51      $ 0:0:1.5��6'   $ 1Q�69   52      T� 53      $* $(FrameworkElement.VerticalAlignment)�6,   $ 
titleBlock��6m   ..�54      i� $ 0��6)   # Z 65   i� 55      $ 0:0:0.5��6)   # Z 6;   56      r� 57      $ (FrameworkElement.Margin)�6/   $ image��6e   .	�58        $ 0��6*   $	 0q�66     59      $ 0:0:0.5��6*   $	 0q�6<     5:      $ 0:0:1.2��6*   $	 
0,-500,0,0q�6<   5;      r� 5<      $ (FrameworkElement.Margin)�6/   $ 
titleBlock��6e   .	�5=        $ 0:0:0.5��6*   $	 	0,190,0,0q�6<     5>      $ 0:0:1.2��6*   $	 
0,-300,0,0q�6<   5?      �� 5@      $6 0(TextElement.Foreground).(SolidColorBrush.Color)�6+   $ 	userBlock��6x   .g�5A        $
 0��6&   $ Black��62     5B      $
 0:0:0.8��6&   $ 	#FF9C9C9C��68     5C      $
 0:0:1.5��6&   $ Black��68   5D      U� 5E      $ (UIElement.Opacity)�6,   $ image��6\   .\�5F        $ 0��6'   $ 1Q�63     5G      $ 0:0:0.5��6'   $ 1Q�69   5H      U� 5I      $ (UIElement.Opacity)�6,   $ 
titleBlock��6\   .\�5J        $ 0��6'   $ 1Q�63     5K      $ 0:0:0.5��6'   $ 1Q�69   5L      �� 5M      $6 0(TextElement.Background).(SolidColorBrush.Color)�6+   $ 	passBlock��6x   .g�5N        $
 0��6&   $ White��62     5O      $
 0:0:0.8��6&   $ Black��68     5P      $
 0:0:1.5��6&   $ White��68   5Q      �� 5R      $6 0(TextElement.Foreground).(SolidColorBrush.Color)�6+   $ 	passBlock��6x   .g�5S        $
 0��6&   $ Black��62     5T      $
 0:0:0.8��6&   $ 	#FFA8A8A8��68     5U      $
 0:0:1.5��6&   $ Black��68   5V      T� 5W      $ (UIElement.Visibility)�6,   $ logInButton��6_   ..�5X      i� $ 0��6)   # Z 65   i� 5Y      $ 0:0:0.8��6)   # Z 6;   5Z      T� 5[      $ (UIElement.Visibility)�6,   $ userBox��6_   ..�5\      i� $ 0��6)   # Z 65   i� 5]      $ 0:0:0.8��6)   # Z 6;   5^      T� 5_      $ (UIElement.Visibility)�6,   $ passBox��6_   ..�5`      i� $ 0��6)   # Z 65   i� 5a      $ 0:0:0.8��6)   # Z 6;   5b      T� 5c      $ (UIElement.Visibility)�6,   $ 	userBlock��6_   ..�5d      i� $ 0��6)   # Z 65   i� 5e      $ 0:0:0.8��6)   # Z 6;   5f      T� 5g      $ (UIElement.Visibility)�6,   $ 	passBlock��6_   ..�5h      i� $ 0��6)   # Z 65   i� 5i      $ 0:0:0.8��6)   # Z 6;   5j      T� 5k      $ (UIElement.Visibility)�6,   $ signUpButton��6_   ..�5l      i� $ 0��6)   # Z 65   i� 5m      $ 0:0:0.8��6)   # Z 6;   5n      T� 5o      $ (UIElement.Visibility)�6,   $ forgotButton��6_   ..�5p      i� $ 0��6)   # Z 65   i� 5q      $ 0:0:0.8��6)   # Z 6;   5r      T� 5s      $ (UIElement.Visibility)�6,   $ forgotBlock��6_   ..�5t      i� $ 0��6)   # Z 65   i� 5u      $ 0:0:0.8��6)   # Z 6;   5v      5w      5x       � Triggers 5y      :� 5z   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5{      �� -   5         ��Name$ Opening_BeginStoryboard��5{      #��[  6?   5|      .��5      � .+�5�   
   �� -   5         ��Name$ image��5�      $��Center=�6   $��114.5��6<   $��Center=�6K   $��123.5��6f   $��143.5,75.5,144,541q�6t   $��/img/airplaneteal.png��6�   $y�Visible=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5�   
   -   5         ��Name$ logInButton��5�      $��Log In��6&   $��Center=�67   $	��Top=�6T   $	��127��6l   $��	0,560,0,0q�6x   $��25(�6�   $��39��6�   6�   �� 5�   
   -   5         ��Name$ userBox��5�      $��Center=�6#   $��50��6@   $��	0,400,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��340��6�   $��2q�6�   ���#000000
����� �$��35(�6�   ���#ffffff J� Opacity$	 0.7Q�6�   G� 5�   
   -   5         G�Name$ passBox��5�      $��Center=�6'   $��50��6D   $��	0,500,0,0q�6P    G� PasswordChar$ *��6c   $	��Top=�6t   $	��340��6�   $��2q�6�   ���#000000
����� �$��35(�6�   ���#ffffff$	 0.7Q�6�   �� 5�   
   -   5         ��Name$ 	userBlock��5�      $��Center=�6'   $��39.478,355,222.478,0q�6D   $
��Wrap=�6b   $��	Username:��6v   $	��Top=�6�   $��32(�6�   
���   �$	 0.6Q�6�   
������� J� OpacityMask 6�   Z� 6�   �� 5�   
   -   5        $ 	passBlock��5�      $��Center=�6'   $��-190,455,0,0q�6D   $
��Wrap=�6Z   $	��Top=�6n   $��32(�6�   
���   �
���   �$	 0.6Q�6�   �� 6�   
�������$�	Password:��6�   6�   �� 5�   
   -   5        $ 
titleBlock��5�      $��Center=�6(   $��	0,190,0,0q�6E   $
��Wrap=�6X   $��
ExploreYYC��6l   $	��Top=�6~   $��70(�6�   ���#ffffff6�   �� 5�   
   -	   5        $ signUpButton��5�      $��Sign Up��6'   $��Center=�69   $	��Top=�6V   $	��127��6n   $��	0,610,0,0q�6z   $��25(�6�   $��39��6�   6�   �� 5�   
   -
   5        $ 	failBlock��5�      $��Center=�6'   $��	0,320,0,0q�6D   $
��Wrap=�6W   $%��Incorrect Username or password.��6k   $	��Top=�6�   $��25(�6�   $	��380��6�   
���   �$y�Hidden=�6�   
�������$	 0.6Q�6�   �� 5�   
   -   5        $ forgotButton��5�      $��39��6(   $	��200��64   $��	0,660,0,0q�6@   $��Center=�6S   $	��Top=�6p   
������ .��5�      �� -   5        $ forgotBlock��5�      $��Center=�6-   $��0,0,0,0q�6J   $
��Wrap=�6[   $��Forgot password?��6o   $	��Top=�6�   $��25(�6�   $	��200��6�   
����� �$��	Underline{�6�   5�      ��5�   
   �� 5�      -   5        
background�� �� ImageSource$ img/tower3.png��5�   .    j� Stretch$ Uniform=�6K    �� RelativeTransform 5�      V� 5�      .~�5�      ��  �� CenterY$	 0.5Q�6)    �� CenterX$	 0.5Q�67     �� ScaleX$  2Q�6E   ! �� ScaleY$! 2Q�6P   �� 5�      " �� CenterY$	" 0.5Q�6(   # �� CenterX$	# 0.5Q�66   �� 5�      $ �� CenterY$	$ 0.5Q�6*   % �� CenterX$	% 0.5Q�68   T� 5�      5�      5�      5�      5�      