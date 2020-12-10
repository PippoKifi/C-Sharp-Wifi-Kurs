using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Items.Tests
{
    [TestFixture] //Das ist das Test Objekt (was ist testen möchte)
    public class mp3ItemTests
    {
        //private IPlaylistItem _fixture;

        //COVERAGE (Unter Extensions -> Manager ) -> Teste


        [Test]
        public void GetTitle()
        {
            //3 Must Have (AAA-Prinzip)
            //  ---1> Arrange (Arrangieren | Variablen vorbereiten)
            //  ---2> Act (Ausführen)
            //  ---3> Assert (Prüfen)



            //1> Arrange (Arrangieren | Variablen vorbereiten)
            Guid _fixture = Guid.NewGuid();
            FileInfo path = new FileInfo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");
            var fixture = new mp3Item(path, _fixture);

            //2>Act (Ausführen)
            var title = fixture.Titel;


            //3>Assert (Prüfen)
            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("Grenade"));
        }

        [Test]
        public void GetTitle_FilePathIsNull()
        {
            Guid _fixture = Guid.NewGuid();
            FileInfo path = new FileInfo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars #########.mp3");
            var fixture = new mp3Item(path, _fixture);

            var title = fixture.Titel;

            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("Grenade"));

        }


        [Test]
        public void GetDuration()
        {
            Guid _fixture = Guid.NewGuid();
            FileInfo path = new FileInfo(@"C:\Users\user\Music\TestMediaFiles\001 - Bruno Mars #########.mp3");
            var fixture = new mp3Item(path, _fixture);

            var title = fixture.Titel;

            Assert.That(title, Is.Not.Null);
            Assert.That(title, Is.EqualTo("Grenade"));

        }


    }
}
