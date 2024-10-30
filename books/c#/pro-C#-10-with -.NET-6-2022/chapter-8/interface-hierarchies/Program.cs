using interface_hierarchies;

_3DObject my3DObject = new _3DObject();

my3DObject.Draw();
my3DObject.AdvancedDraw();

if (my3DObject is _3DObject CastedMy3DObject)
{
    CastedMy3DObject.Draw();
    CastedMy3DObject.AdvancedDraw();
}