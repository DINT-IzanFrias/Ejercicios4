   M S B A M L   `   `   `  ����F  Bsuperheroes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:superheroessuperheroes  5   	       superheroes.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:superheroes     5   	     � Title$  Superheroes��5   	   $	��450��6   $	��800��6*    � 	Resources 5	      %  superheroes.BackgroundConverter   backgroundConverter%  superheroes.VisibilityConverter  visibilityConverter  flechas �� 
TargetType �� Property �� Value  contador��%  &	        &	      &	 &     &	 n       5
   
   6$     5   
   6$   �� 5   
   " ��6    .�5      ��  � ��$ 24��67   5      �� 5   
   " ��6!   .�5      ��  � ��$ 20(�63   �� 5       � ��$
 Bold"�65   5      5      .��5      ]� -   5         ]�Name$ superheroeDockPanel��5      ��5      ��  �� Path$ Heroe� �� 	Converter# [  .+�5   
   ]� $��false��6   $	��Top=�6*   .+�5      �� $
��Left=�6   $��Bottom=�6.   $��40(�6I   
�������$��Segoe UI Black)�5      $��10,0,0,0q�6.   ��6@   �� $ Nombre� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      	 �� Orientation$	 
Horizontal=�6   $��Right=�62   $��Bottom=�6I   .+�5      �� $��40��6   $��0,0,10,0q�6#   $��/avengers.png��5   e   y�6   �� $ Vengador�# [ 6e   �� 5       $��60��6   $��	/xmen.png��5!   a   y�6   �� $
 Xmen�# [ 6a   �� 5"      $��68��6   $��
/mafia.png��5#   e   y�6   �� $ Villano�# [ 6e   5$      5%      �� 5&   
   $��Bottom=�6   $	 
Horizontal=�6-   $��Center=�6F   .+�5'      �� -   5        
 ��Name$
 	leftImage��5'   D   #��[ 6W   $��
/arrow.png��6x   �� 5(      -   5         ��Name$ actualPosition��5(      #��[ 60   $��5,0,0,5q�6R   �� 5)      #��[ 6   $��0,0,0,5q�6:   /6N   �� 5*      -   5        $ totalPositions��5*      #��[ 60   $��0,0,5,5q�6R   �� 5+      -   5        $
 
rightImage��5+   E   #��[ 5,       J� RenderTransformOrigin$ 0.5,0.5&�6/   $��
/arrow.png��6O   z�5-      V� 5.      .~�5/      ��  �� ScaleY$ 1Q�6)    �� ScaleX$ -1Q�64   �� 50       �� AngleY$ 0Q�6(    �� AngleX$ 0Q�63   �� 51       �� Angle$ 0Q�6*   T� 52      53      55      56      �� 57   
   $��UniformToFill=�6   $��10q�6(   ��64   �� $ Imagen�58      59      