   M S B A M L   `   `   `  ����Q  MExploreYYCHighFidelity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ExploreYYCHighFidelityExploreYYCHighFidelity  5      #    ExploreYYCHighFidelity.SignUp   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ExploreYYCHighFidelity     5      .��5
      � .+�5   
   �� -   5          ��Name$  
backButton��5      $��< Back��6%   $
��Left=�69   $	��Top=�6T   $��90��6l   $��0,30,0,0q�6w   $��25(�6�   $��39��6�   
�������
���   ���6�   Z� 6�   �� 5   
   -   5         ��Name$ createBlock��5      $��Center=�6)   $��0,70,0,0q�6F   $
��Wrap=�6X   $��Create Account��6l   $	��Top=�6�   $��50(�6�   
�������6�   �� 5   
   -   5        $  signUpButton��5      $��Sign Up��6'   $��Center=�69   $	��Top=�6V   $	��130��6n   $��	0,600,0,0q�6z   $��25(�6�   $��39��6�   6�   �� 5   
   -   5        $ 	failBlock��5      $��Center=�6'   $��	0,160,0,0q�6D   $
��Wrap=�6W   $#��Error! Passwords do not match��6k   $	��Top=�6�   $��28(�6�   ���#ffffff$y�Hidden=�6�   �� 5   
   -   5         ��Name$ emailBox��5      $��Center=�6$   $��50��6A   $��	0,230,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��340��6�   $��2q�6�   ���#000000
����� �$��35(�6�   
������� J� Opacity$	 0.7Q�6�   �� 5   
   -   5        $ 
emailBlock��5      $��Center=�6(   $��-265,192,0,0q�6E   $
��Wrap=�6[   $��Email:��6o   $	��Top=�6}   $��28(�6�   
���   �
�������$	 0.6Q�6�   �� 5   
   -   5        $ userBox��5      $��Center=�6#   $��50��6@   $��	0,330,0,0q�6L   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��340��6�   $��2q�6�   ���#000000
����� �$��35(�6�   ���#ffffff$	 0.7Q�6�   �� 5   
   -   5        $ 	userBlock��5      $��Center=�6'   $��-205,294,0,0q�6D   $
��Wrap=�6Z   $��	Username:��6n   $	��Top=�6   $��28(�6�   
���   �$	 0.6Q�6�   $��19��6�   
�������6�   G� 5   
   -	   5         G�Name$ passBox��5      $��Center=�6'   $��50��6D   $��	0,430,0,0q�6P    G� PasswordChar$ *��6c   $	��Top=�6u   $	��340��6�   $��2q�6�   ���#000000
����� �$��35(�6�   ���#ffffff$	 0.7Q�6�   �� 5   
   -
   5        $ 	passBlock��5      $��Center=�6'   $��-215,394,0,0q�6D   $
��Wrap=�6Z   $��	Password:��6n   $	��Top=�6   $��28(�6�   
���   �
�������$	 0.6Q�6�   G� 5   
   -   5        $ confirmPassBox��5      $��Center=�6.   $��50��6K   $��	0,530,0,0q�6W   $ *��6j   $	��Top=�6{   $	��340��6�   $��2q�6�   ���#000000
����� �$��35(�6�   ���#ffffff$	 0.7Q�6�   �� 5   
   -   5        $ confirmPassBlock��5      $��Center=�6.   $��-110,493,0,0q�6K   $
��Wrap=�6a   $��Confirm Password:��6u   $	��Top=�6�   $��28(�6�   
���   �$	 0.6Q�6�   
�������6�   ��5   
   �� 5      -   5        
background�� �� ImageSource$ img/tower3.png��5   -    j� Stretch$ Uniform=�6J   	 �� RelativeTransform	 5      V� 5      .~�5      �� 
 �� CenterY$	
 0.5Q�6)    �� CenterX$	 0.5Q�67    �� ScaleY$ 2Q�6E    �� ScaleX$ 2Q�6P   �� 5       �� CenterY$	 0.5Q�6(    �� CenterX$	 0.5Q�66   �� 5       �� CenterY$	 0.5Q�6*    �� CenterX$	 0.5Q�68   T� 5      5      5!      5$      5%      