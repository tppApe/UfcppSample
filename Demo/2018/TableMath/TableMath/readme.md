# 三角関数テーブル化

極まってくると、`Math.Sin`の負荷を避けたく、三角関数の値をテーブル化してしまいたくなるやつ。
角度の解像度がそんなに要らない時用。とりあえず、1周256分割の解像度で実装。
256分割だと、一番ずれているところで誤差2%以下くらい。