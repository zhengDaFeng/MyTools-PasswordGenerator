   M S B A M L   `   `   `  ����L  HPasswordGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PasswordGeneratorPasswordGenerator  5   	   "    PasswordGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PasswordGenerator     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
MainWindow��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   $��Center=�6;   $��Center=�6X   $	��300��6s   $	��250��6   .��5      �� $��Center=�6   $��Center=�6.   .+�5   
   ��    MaterialDesignTitleTextBlock#���  5      $��Center=�5       �� Padding$ 10, 10, 10, 10q�5      $!��Zdfffg's Password Generator��5       � ToolTip$ 看什么看...��60   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5         ��Name$ cbUpper��5      $��10, 10, 10, 10q�6(    d� 	IsChecked$
 TrueY�6A   $ 大写字母��6R   .��6a   A-Z6f   �� 5      -   5        $ cbDown��5      $��10, 10, 10, 10q�6'   $
 TrueY�6@   $ 小写字母��6Q   .��6`   a-z6e   �� 5      -   5        $ 	cbDigital��5      $��10, 10, 10, 10q�6*   $
 TrueY�6C   $ 数字��6T   .��6a   0-96f   �� 5      -   5        $ 	cbSpecial��5      $��10, 10, 10, 10q�6*   $
 TrueY�6C   $ 特殊字符��6T   .��6c   !@#...6k   5      �� 5   
   -   5         ��Name$ 	sldLength��5      $ 生成密码长度设置��6$   $��35, 10, 35, 10q�5      	 � Minimum$	 4Q�5      
 � Maximum$
 24Q�5        �� AutoToolTipPlacement$ BottomRight=�6    � SmallChange$ 1Q�6A    � Value$ 12Q�6Q   �� 5!   
   -   5         ��Name$ btnGenerate��5!      $	��180��6&   $ 密码生成��62   .��6[   
Generate6e   �� 5"   
   $ 
Horizontal=�5#      $��Center=�5$      .+�5%      �� -   5         ��Name$ 
tbPassword��5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
 Password ��5&      $ 已生成的随机密码��5'      $��10, 10, 5, 10q�5(      6/   �� 5)      -   5        $ btnCopy��5)      $��5, 10, 10, 10q�5*       / +MaterialDesignFloatingActionMiniLightButton#��[ 5+      $$ 复制当前密码到剪切板��5,      .��5.      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ ContentCopy=�5/      $��24��50      $��24��51      52      53      54      55      