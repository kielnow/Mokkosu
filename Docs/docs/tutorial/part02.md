# ��2�� ��{�I�ȍ\���ƌ^

## �o�̓E�C���h�E�ւ̏�������
����܂Ōv�Z���ʂ�\������̂�`msgbox`�֐����g���Ă��܂������A
`println`�֐����g����MokkosuPad�̏o�̓E�C���h�E�Ɍ��ʂ��������ނ��Ƃ��ł��܂��B
�ȉ��̃v���O���������s����ƁA�o�̓E�C���h�E��`"Hello, World."`�ƕ\������܂��B
```
println "Hello, World.";
```

�ގ��̊֐��Ƃ���`print`�֐�������܂��B
`println`�֐��͏o�͌�ɉ��s����̂ɑ΂��A`print`�֐��͉��s���܂���B
�ȉ���`print`�֐��̎g�p��ł��B
```
print "2 * 3 = ";
println (2 * 3);
```
���s����ƁA
```
2 * 3 = 6
```
�ƕ\������܂��B

## �Ǐ��ϐ�
�֐��̒�`���ɂ��̒��ł̂ݗL���ȕϐ����g���������Ƃ�����܂��B
���̂悤�Ȏ��́A�Ǐ��ϐ����g���܂��B
�Ǐ��ϐ���let���Œ�`���܂��B

```
let �ϐ��� = ��1 in ��2
```

let����`��1`���v�Z���Ă��̌��ʂɖ��O��t����`��2`���v�Z���܂��B
�t�������O��`��2`�̒��ł̂ݗL���ł��B

�ȉ��͋Ǐ��ϐ����g���āAx��4������߂�֐�`pow4`���`������ł��B

```
fun pow4 x =
  let x = x * x in
  x * x;
```

���̗�̂悤��let���͊����̒�`�ς݂̖��O���㏑�����܂��B
��̃v���O������let���̉E�ӂ�`x`�͈�����x�B 
`in`�ȍ~�̎���`x`��let���œ�������`x`�ł��B
������₷�����O��ς���ƈȉ��̂悤�ɂȂ�܂��B

```
fun pow4 x =
  let y = x * x in
  y * y;
```

�v���O�����̊����̕ϐ����㏑������ƁA�v���O�������ǂ݂ɂ����Ȃ�\��������܂����A
�����ɁA�Â��l���Q�Ƃ��Ă��܂��̂�h�~������ʂ�����܂��B

let���͈ȉ��̂悤�ɘA�����Ďg�����Ƃ��ł��܂��B
```
fun f x y =
  let a = x * x in
  let b = y * y in
  a + b;
```

## ���������_��
����܂ł͐����̉��Z�������Ă��܂������A���͕��������_���������Ă݂܂��傤�B
���������_���������ƁA`3.14`�̂悤�ȏ����_���܂ޒl�A
`6.22e23`�̂悤�ȂƂĂ��傫�Ȑ��A
`-1.60e-19`�̂悤�ȂƂĂ������Ȑ����������Ƃ��\�ɂȂ�܂��B

���������_���̌^��`Double`�^�ł��B

Mokkosu�ł�`Double`�^�̉��Z�ɐ����Ƃ͈قȂ鉉�Z�q���g���܂��B
`Double`�^�Ɋւ��鉉�Z�q���ȉ��Ɏ����܂��B

|���Z�q|�Ӗ�|
|------|----|
|`��1 +. ��2`|���Z|
|`��1 -. ��2`|���Z|
|`��1 *. ��2`|��Z|
|`��1 /. ��2`|���Z|
|`~-.��`|�������]|

�ȉ��͉~�̖ʐς����߂�֐����`���Ďg����ł��B

```
fun area_of_circle r = r *. r *. pi;

print "���a5.0�̉~�̖ʐ�: ";
println (area_of_circle 5.0);
```

���s����Əo�̓E�C���h�E�Ɉȉ��̂悤�ɕ\������܂��B

```
area_of_circle : Double -> Double

���a5.0�̉~�̖ʐ�: 78.5398163397448
```

���������_���𐮐��𑊌ݕϊ�����ɂ́A
`int_to_double`�֐���`double_to_int`�֐����g���܂��B

```
int_to_double : Int -> Double
double_to_int : Double -> Int
```

���������_���Ɋւ��ẮA��������O�p�֐��ȂǗL�p�Ȋ֐���������
�W�����C�u�����ɒ�`����Ă��܂��B
�ڍׂ�[���t�@�����X�}�j���A���̕��������_���̐�](../reference/corelib.md#_16)
���Q�Ƃ��Ă��������B

### ���K��� 2.1
�~���̑̐ς����߂�֐����`���Ă��������B

### ���K��� 2.2
�K���Ȍ������g���ĉ~�����΂̒l�����߂�v���O�����������Ă��������B

## �����ƕ�����
`'A'`��`'��'`�̂悤�ɕ������V���O���N�H�[�e�[�V�����ň͂������̂�
�����萔�Ƃ��`Char`�^�������܂��B

`Char`�^�̒l�͕����R�[�h���Ȃ킿�����l�Ƒ��ݕϊ��ł��܂��B
```
char_to_int : Char -> Int
int_to_char : Int -> Char
```

`"abc"`�̂悤�ɕ�������_�u���N�H�[�e�[�V�����ň͂������̂�
������萔�Ƃ��`String`�^�������܂��B

�������`^`���Z�q���g���ĘA���ł��܂��B

```
let message = "Hello, " ^ "World.";
```

������̒��������߂�ɂ�`strlen`�֐��A
�����񒆂�n�Ԗڂ̕��������o���ɂ�`strnth`�֐����g���܂��B
```
strlen : String -> Int
strnth : String -> Int -> Char
```

## �^�U�l
`true`��`false`��2�ʂ�̒l�����^`Bool`����`����Ă��܂��B
`==`��`<`�Ȃǂ̔�r���Z�q�̖߂�l�̌^��`Bool`�^�ɂȂ�܂��B

`Bool`�^�Ɋւ��鉉�Z�Ƃ��āA�ȉ��̂��̂���`����Ă��܂��B

|���Z|�Ӗ�|
|----|----|
|��1 && ��2|�_����(����)|
|��1 &#124;&#124; ��2|�_���a(�܂���)|
|xor ��1 ��2|�r���I�_���a|
|not ��1|�ے�|

��̕\�̂����A`&&`��`||`�̓V���[�g�T�[�L�b�g�]������܂��B
���Ȃ킿�A`&&`�̏ꍇ`��1`��`false`�̏ꍇ��`��2`�̌v�Z�͍s��ꂸ�A
`||`�̏ꍇ`��1`��`true`�̏ꍇ��`��2`�̌v�Z�͍s���܂���B

## ���j�b�g
Mokkosu�ɂ͌��ʂ��Ȃ����Ƃ�\��`()`�^�̒l`()`����`����Ă��܂��B
`println`�֐��͈����̒l��\�����܂����A�֐����̖̂߂�l�Ƃ���
�����Ӗ��̂���l��Ԃ��K�v�͂���܂���B
���̂悤�Ȋ֐��̖߂�l��`()`�^���g���܂��B

�Ⴆ��`println`�̌^�͈ȉ��̂悤�ɂȂ��Ă��܂��B
```
println : �� -> ()
```
�����Ń��͔C�ӂ̌^��\���Ă��܂��B
`println`�͎g�����ɂ���āA
```
println : Int -> ()
```
�ɂ��A
```
println : String -> ()
```
�ɂ��Ȃ�A���̑�\�Ƃ��ă��ƕ\�L���Ă��܂��B

## do��
do���͈ȉ��̍\�����������ł��B
```
do ��1 in ��2
```
do����`()`�^�ɂȂ�`��1`���v�Z���āA
���̌��`��2`���v�Z�����̌��ʂ�Ԃ��܂��B

�ȉ��̃v���O������1����10�܂ł̐��l���o�̓E�C���h�E�ɕ\�����܂��B
```
fun print10 n =
  if n > 10 -> ()
  else
    do println n in
    print10 (n + 1);

print10 1;
```
�o�͌��ʂ͈ȉ��̂悤�ɂȂ�܂��B
```
print10 : Int -> ()

1
2
3
4
5
6
7
8
9
10
```

### ���K��� 2.3
`"Hello"`�Ƃ���������̊e������1�s��1�����Â\������v���O����������Ă��������B

### ���K��� 2.4
�ȉ��̂悤�Ȋ|���Z�̋��̕\��\������v���O����������Ă��������B
```
 1  2  3  4  5  6  7  8  9
 2  4  6  8 10 12 14 16 18
 3  6  9 12 15 18 21 24 27
 4  8 12 16 20 24 28 32 36
 5 10 15 20 25 30 35 40 45
 6 12 18 24 30 36 42 48 54
 7 14 21 28 35 42 49 56 63
 8 16 24 32 40 48 56 64 72
 9 18 27 36 45 54 63 72 81
```

