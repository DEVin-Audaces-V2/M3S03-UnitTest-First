using M3S03_UnitTest_First.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3S03_UnitTest_First
{
    public class AutenticacaoTest
    {
        [Test]
        public void ValidaAutenticacao()
        {

            //A senha deve ser criptohtafada em SHA256
            var hash = Criptografia.CriptografarSenha("hello world");

            Assert.AreEqual("uU0nuZNNPgilLlLX2n2r+sSE7+N6U4DukIj3rOLvzek=", hash);
        }

        [Test]
        //Teste de encheção de linguiça,, visto que é pouco assertivo
        public void ValidaAutenticacaoInvalida()
        {

            //A senha deve ser criptohtafada em SHA256
            var hash = Criptografia.CriptografarSenha("hello world");

            Assert.AreNotEqual("MJ7MSJwS1utMxA9QyQLytNDtd+5RGnx6m808qG1M2G+YndNbxf9JlnDaNCVbRbDP2DDoH2Bdz33FVC6TrpzXbw==", hash);
        }
    }
}
