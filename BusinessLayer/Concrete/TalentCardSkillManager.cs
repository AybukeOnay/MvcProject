using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TalentCardSkillManager :ITalentCardSkillService
    {
        ITalentCardSkillDal _talentCardSkillDal;

        public TalentCardSkillManager(ITalentCardSkillDal talentCardSkillDal)
        {
            _talentCardSkillDal = talentCardSkillDal;
        }

        public void Add(TalentCardSkill talentCardSkill)
        {
            _talentCardSkillDal.Insert(talentCardSkill);
        }

        public void Delete(TalentCardSkill talentCardSkill)
        {
            _talentCardSkillDal.Delete(talentCardSkill);
        }

        public List<TalentCardSkill> GetAll()
        {
            return _talentCardSkillDal.List();
        }

        public TalentCardSkill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TalentCardSkill talentCardSkill)
        {
            throw new NotImplementedException();
        }
    }
}
