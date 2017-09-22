import { TaxonomyTerm } from "./taxonomyTerm";
import { Experience } from "./experience";

export class Profile {
    associateName: string;
    associateTitle: string;
    credentials: string;
    associateStatus: TaxonomyTerm[];
    associateSummary: string;
    developmentExperience: TaxonomyTerm[];
    functionalBusinessExperience: TaxonomyTerm[];
    industriesServed: TaxonomyTerm[];
    additionalTechnicalExperience: string;
    clientFeedback: string;
    results: string;
    education: string;
    communityInvolvement: string;
    technicalAndBusinessSkills: TaxonomyTerm[];
    certificationsAndProfessionalMemberships: TaxonomyTerm[];
    completeAssociateProfile: string;
    associateExperiences: Experience[];
}
