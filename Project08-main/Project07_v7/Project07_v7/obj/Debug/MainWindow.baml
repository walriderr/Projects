   M S B A M L   `   `   `  ????G  CProject07_v7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Project07_v7Project07_v7  5   	       Project07_v7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Project07_v7     5   	     ? Title$+  %Реализованный товар??5   	   $	??550??5	   	   $	??900??6   ???#ecdfce ? WindowStartupLocation$ CenterScreen=?5   	    ? 
ResizeMode$ NoResize=?5   	    ? 	Resources 5         btn ?? 
TargetType ?? Property ?? Value ?? 	Resources  	tb_e-mail ?? 
TargetType	 ?Name
 J? SnapsToDevicePixels ??Name ??Name ?? Triggers P? Property P? Value 
 btn_wm??%?  &	        &	 ?     &	 ,    ?? 5   
   " ??6   .?5      ??  ? ??
 ???? 6+   ?? 5       ? ??$ 0q?60    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$ 5??65   5      5      5      ?? 5   
   " ??6"   .?5      ??  ? ??
 ?????6+   ?? 5       ? ??$ Center=?69   ?? 5       ? ??$ 35??6'   ?? 5       ? ??
 ?   ?6+   ?? 5       ? ??$ 17(?6)   ?? 5       ? ??
 ?????6,   ?? 5        ? ??$ 10,0,0,0q?6(   ?? 5!       ? ?? 5"      ?? 5#      " ??6&   .R?5$      ? $
	 root??6   #??z??6-   #??z??6O   
 . .+?5%      ?? $ 
Background??6%   $??1q?69   #??z??6M   #??z??6w   ?? 5&      $ PART_ContentHost??6+   $??0q?6E   #??z??6Y   ??.  #??z??6?   ??6?   Z? 6?   5'       5(      P? 5)       ?@J?IsMouseOver . . ?5*   "   ??  ? ?? ?	#FF383C446@   5+      P? 5,       ?@J?	IsFocused . . ?5-   "   ??  ? ?? ?#ecdfce6@   5/      51      53      54      ?? 56   
   " ??6    57      ???? 58      '??       " ??6   .?59      ??  ?@??CornerRadius$ 5??65   5:      5;      5<      5=      .??5?      ?  ? ColumnDefinitions 5@   
   ?? 5A      $	??130 ?6   ?? 5B      .+?5E   
   ?? ???#ececea$??0??6*   .+?5F      ?? $??Assets/Twinkle_logo_3.png??6   $??5q?67   ?? 5H      -   5         ??Name$ btn_Home??5H   2   #??[  6   $??50??6D   $??50??6O   $??0,10,0,0q?6[   ??5I      ?? 5J       ?? ImageSource$ Assets/home_icon.png??6!   5L      ?? 5N      -   5        $ btn_Edit??5N   2   #??[  6   $??50??6D   $??50??6O   $??0,20,0,0q?6[   ??5O      ?? 5P      $ Assets/edit_icon.png??6!   5R      ?? 5T      -   5        $ btn_Add??5T   2   #??[  6   $??50??6C   $??50??6N   $??0,20,0,0q?6Z   ??5U      ?? 5V      $ Assets/add_icon.png??6!   5X      ?? 5Z      -   5        $ 
btn_Delete??5Z   2   #??[  6   $??50??6F   $??50??6Q   $??0,20,0,0q?6]   ??5[      ?? 5\      $ Assets/delete_icon.png??6!   5^      5_      ?? 5a   
   $
??1000??6   $
??1000??6   $??1q?6,   $??1??6@   
???????$??0,-21,-236,-458q?6c   ? 5c   
   $??1??6   .+?5e      ?? 
???????$??0q?6(   $??40q?6<   ._?5f      ?  ? RowDefinitions 5g      ?? 5h      $	??245 ?6(   ?? 5i      ?? 5j      $	??100 ?6(   ?? 5k      $??25 ?6(    5n      ?? 5o      $	??260 ?6+   ?? 5p      .+?5t      ? $??0??6   .+?5u      ?? $??Скидка 10%??6$   $??Center=?66   $??Center=?6Q   $??22(?6n   $??Arial)?6|   $??	0,0,0,110q?6?   ?? 5v      $ ??ДОПОЛНИТЕЛЬНО??6$   $??Center=?69   $??Center=?6T   $
??Bold"?6q   $??22(?6?   $??Arial)?6?   $??0,0,0,55q?6?   ?? 5w      $8??2За подписку на наши новости??6$   $??Center=?6G   $??Center=?6b   $
??Thin"?6   $??13(?6?   $??Arial)?6?   $??0,0,0,15q?6?   ?? 5y      -   5         ??Name$ tb_email??5y   "   #??[ 64   $??
10,60,10,0q?6W   ?? 5z       J? IsHitTestVisible .  $$??Введите свой e-mail??6=   $??12(?6X   
???????$
??Thin"?6x   $??Arial)?6?   $??Center=?6?   $??Center=?6?   $??2??6?   $??0,60,0,0q?6?   ??5{      ?? 5|   "   " ??6(   .?5}   &   ??  ? y?$ 	Collapsed=?6C    ?? Triggers 5~   &   ?? 5   *    ?? Binding 66   ?? *Text+ ?? ElementName$ tb_email?? ?? Value  6e   .a?5?   .   ??  ? y?$ Visible=?6K   5?   +   5?   #   5?      ?? 5?      -   5        $ 	btn_women??5?   V   #??[ 6!   $??Для женщин??6A   ???#2796ff
?????? $	??110??6?   
???????$??Arial)?6?   $??11(?6?   $
??Thin"?6?   $??30??6?   $??Bottom=?6?   $??10,0,140,32q?6  ?? 5?      -   5        $ btn_man??5?   V   #??[ 6!   $??Для Мужчин??6A   ???#2796ff
?????? $	??110??6?   
???????$??Arial)?6?   $??11(?6?   $
??Thin"?6?   $??30??6?   $??Bottom=?6?   $??140,0,10,32q?6  5?      ? 5?      $??1??6   .+?5?      ?? $*??$Assets/png_shops/background_apps.png??6    $??Right=?6N   ?? 5?      $-??'Мобильное приложение??6$   $??Arial)?6@   $??DemiBold"?6S   $??15(?6i   $??Center=?6w   $??Center=?6?   $??218,0,0,115q?6?   ?? 5?      $,??&Покупать еще удобнее??6$   $??Center=?6@   $??Center=?6[   $
??Thin"?6x   $??12(?6?   $??Arial)?6?   $??
210,0,0,75q?6?   ?? 5?      #??[  6!   
?????? $	??120??6X   $??35??6d   $??
213,15,0,0q?6p   ??5?      ?? 5?   "   $) #Assets/png_shops/app-banner_ios.png??6-   5?      ?? 5?      #??[  6!   
?????? $	??120??6X   $??35??6d   $??213,115,0,0q?6p   ??5?      ?? 5?   "   $- 'Assets/png_shops/app-banner_android.png??6-   5?      5?      ? 5?      $??2??6   $??2??6/   .+?5?      ? $??Center=?6$   $??Center=?6A    ? Orientation$ 
Horizontal=?6\   .+?5?      ?? $??Assets/png_shops/nike.png??6$   $??10q?6G   ?? 5?      $ ??Assets/png_shops/asics.png??6$   $??10q?6H   ?? 5?      $ ??Assets/png_shops/tommy.png??6$   $??10q?6H   ?? 5?      $??Assets/png_shops/gap.png??6$   $??10q?6F   ?? 5?      $!??Assets/png_shops/adidas.png??6$   $??10q?6I   5?      5?      5?      5?      5?      5?      5?      