# Generated by Django 4.2.4 on 2023-09-29 16:48

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('network', '0003_follow'),
    ]

    operations = [
        migrations.RenameField(
            model_name='follow',
            old_name='original_user',
            new_name='origin_user',
        ),
    ]
