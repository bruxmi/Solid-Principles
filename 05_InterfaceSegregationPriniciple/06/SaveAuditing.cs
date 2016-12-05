using System;
using System.Threading;

namespace Solid._05_InterfaceSegregationPriniciple._06
{
    public class SaveAuditing<TEntity>: ISave<TEntity>
    {
        private readonly ISave<TEntity> _decorated;
        private readonly ISave<AuditInfo> _auditSave;

        public SaveAuditing(ISave<TEntity> decorated, ISave<AuditInfo> auditSave)
        {
            _decorated = decorated;
            _auditSave = auditSave;
        }

        public void Save(TEntity entity)
        {
            this._decorated.Save(entity);
            var auditInfo = new AuditInfo
            {
                UserName = Thread.CurrentPrincipal.Identity.Name,
                TimeStamp = DateTime.Now
            };
            this._auditSave.Save(auditInfo);
        }
    }
}
